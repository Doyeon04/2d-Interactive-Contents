using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshCannonBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision) // collision: �浹�� ��ü
    {
        if (collision.gameObject.tag == "ChickBall" || collision.gameObject.tag == "Item")
            // �浹�� object�� ������ �ִ� �±װ� ChickBall �Ǵ� Item �̶�� 
        {
            Destroy(collision.gameObject); // �浹�� object�� destroy
            Destroy(gameObject); // �ڱ� �ڽŵ� destroy 
        }
    }
}
