using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // 선언 -> 초기화 -> 호출
    Rigidbody rigid;

    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void Start() {
        rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
    }

    // 콜라이더 영역안에 들어왔는지 판별해줌
    void OnTriggerEnter(Collider other) // 처음 들어왔을 때
    {
        Debug.Log(other.gameObject.name + "들어왔다");
    }

    void OnTriggerExit(Collider other) // 나갈때
    {
        Debug.Log("나갔다");
    }

    void OnTriggerStay(Collider other) // 들어왔을때
    {
        Debug.Log("들어와있다");
    }
    
    // 통과하지 않고 충돌했을 때 실행됨
    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.gameObject.tag != "Finish"){
            Debug.Log("충돌");
        }
    }

    // void OnCollisionExit(Collision collisionInfo)
    // {
    //     Debug.Log("충돌안함");
        
    // }

    // void OnCollisionStay(Collision collisionInfo)
    // {
    //     Debug.Log("충돌중");
        
    // }
}
