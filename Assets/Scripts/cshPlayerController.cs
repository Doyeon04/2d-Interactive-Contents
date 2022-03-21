using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshPlayerController : MonoBehaviour
{
    public float speed = 8f;//Player의 이동 속도
    public float moveableRange = 5.5f; // 이동 가능한 범위
    public float power = 1000f; // CannonBall을 발사하는 힘

    void Update()
    {
        //Player 이동 (이동 범위를 movableRange로 제한)
        transform.Translate(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, 0, 0);
        transform.position
        = new Vector2(Mathf.Clamp(transform.position.x, -moveableRange, moveableRange), transform.position.y);
    }
}
