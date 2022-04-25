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

    private void OnCollisionEnter2D(Collision2D collision) // collision: 충돌된 물체
    {
        if (collision.gameObject.tag == "ChickBall" || collision.gameObject.tag == "Item")
            // 충돌된 object가 가지고 있는 태그가 ChickBall 또는 Item 이라면 
        {
            Destroy(collision.gameObject); // 충돌된 object를 destroy
            Destroy(gameObject); // 자기 자신도 destroy 
        }
    }
}
