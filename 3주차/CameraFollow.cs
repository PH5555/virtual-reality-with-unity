using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // 카메라와 움직이는 오브젝트가 일정한 거리를 두고 따라다니게 만들거에요

    [SerializeField]
    Transform user;

    Vector3 offset;
    
    void Awake() {
        // 둘 간의 거리
        offset = transform.position - user.position;
    }

    void Update()
    {
        // 이 카메라의 위치는 항상 큐브의 위치 + 처음 큐브와 카메라의 거리
        transform.position = user.position + offset;
    }
}
