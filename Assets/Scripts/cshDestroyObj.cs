using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshDestroyObj : MonoBehaviour
{
    //오브젝트를 제거하는 인터벌
    public float deleteTime = 2.0f;

    void Start()
    {
        //오브젝트를 생성한 후 deleteTime 만큼 시간이 경과하면 제거
        Destroy(gameObject, deleteTime);
        //여기서 gameObject는 스크립트를 가지고 있는 나 자신
    }
}

