using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshItemGenerator : MonoBehaviour
{

    public GameObject obj; //Item Prefab ����
    public float interval = 3.0f; //������ �Լ��� ȣ��� ���͹�


    // Start is called before the first frame update
    void Start()
    {
        //SpawnObj�Լ��� ������ ����� 0.5�� �Ŀ� ȣ��, ���� interval�� ���� ȣ�� �ȴ�.
        InvokeRepeating("SpawnObj", 0.5f, interval);   
    }


    void SpawnObj()
    {
        float rnd = Random.Range(-3.0f, 3.0f); // -3.0���� 3.0������ �������� ����
        Vector2 pos = new Vector2(transform.position.x + rnd, transform.position.y); // ���� ��ġ�� �������� x�� rnd��ŭ ���� 

        Instantiate(obj, pos, transform.rotation); // obj�� ������ ��ġ, ���⿡�� ����
    }
}
