using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshItemGenerator : MonoBehaviour
{

    public GameObject obj; //Item Prefab 설정
    public float interval = 3.0f; //다음에 함수가 호출될 인터벌


    // Start is called before the first frame update
    void Start()
    {
        //SpawnObj함수를 게임이 실행된 0.5초 후에 호출, 이후 interval초 마다 호출 된다.
        InvokeRepeating("SpawnObj", 0.5f, interval);   
    }


    void SpawnObj()
    {
        float rnd = Random.Range(-3.0f, 3.0f); // -3.0에서 3.0사이의 랜덤값을 생성
        Vector2 pos = new Vector2(transform.position.x + rnd, transform.position.y); // 현재 위치를 기준으로 x만 rnd만큼 조절 

        Instantiate(obj, pos, transform.rotation); // obj를 지정된 위치, 방향에다 복제
    }
}
