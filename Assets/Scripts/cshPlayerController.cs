using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshPlayerController : MonoBehaviour
{
    public float speed = 8f;//Player�� �̵� �ӵ�
    public float moveableRange = 5.5f; // �̵� ������ ����
    public float power = 1000f; // CannonBall�� �߻��ϴ� ��

    void Update()
    {
        //Player �̵� (�̵� ������ movableRange�� ����)
        transform.Translate(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime, 0, 0);
        transform.position
        = new Vector2(Mathf.Clamp(transform.position.x, -moveableRange, moveableRange), transform.position.y);
    }
}
