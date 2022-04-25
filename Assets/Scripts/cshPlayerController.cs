using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshPlayerController : MonoBehaviour
{
    public float speed = 8f;//Player의 이동 속도
    public float moveableRange = 5.5f; // 이동 가능한 범위
    public float power = 1000f; // CannonBall을 발사하는 힘

    // 포탄 발사 변수 추가
    public GameObject cannonBall; //Player에서 발사할 CannonBall
    public Transform spawnPoint; //Cannon 발사 지점
    // Transform: position, rotation, scale


    void Update()
    {
        //Player 이동 (이동 범위를 movableRange로 제한)
        transform.Translate(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, 0, 0);
        //x축으로 horizontal 방향으로 speed 만큼의 속도로 
        //horizontal: 왼쪽을 누르면 -1, 오른쪽을 누르면 +1 이동 시킴

        transform.position
        = new Vector2(Mathf.Clamp(transform.position.x, -moveableRange, moveableRange), transform.position.y);
        //transform.position.x 값이 -5.5f보다 작아지거나 5.5f보다 커지면 각각 -5.5f, 5.5f로 

        // 포탄 발사 기능 추가  
        if (Input.GetKeyDown(KeyCode.Space))  //스페이스키 버튼 이벤트 처리
        {
            Shoot(); //Shoot함수 호출
        }

    }
    void Shoot()
    {
        //복제된 새 cannonBall을 생성하여 newBullet에 할당
        GameObject newBullet = Instantiate(cannonBall, spawnPoint.position, Quaternion.identity) as GameObject;
        // cannonBall을 지정된 위치(발사 지점)에 지정된 방향으로 복제 
        //newBullet의 Rigidbody2D를 참조하여 AddForce 함수로 물리적으로 발사
        //Quaternion.identity: 회전 성분 (0, 0, 0)

        newBullet.GetComponent<Rigidbody2D>().AddForce(Vector3.up * power);
        //복제된 cannonball이 가지고 있는 속성중 rigidbody2D에 힘을 추가(y축으로 power만큼)
        //위로 발사하다 힘이 상쇄되면 중력의 영향을 받아 땅으로 떨어짐
    }



}
