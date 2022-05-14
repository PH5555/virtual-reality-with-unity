using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// UI를 조작할 때 필요한 패키지
using UnityEngine.UI;

public class Move : MonoBehaviour
{ 
    
    [SerializeField]
    float speed = 0.5f;
    float h, v;
    bool isJump, canJump;
    Rigidbody rigid;
    public Text scoreText;

    void Awake()
    {
        rigid = GetComponent<Rigidbody>();
    }

    
    void Update() // 매 프레임 실행 됨
    {
        
        GetInput();
        Movement();
        Jump();
    }

    void GetInput(){
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
        isJump = Input.GetKeyDown(KeyCode.Space);
    }

    void Movement(){
        Vector3 vector = new Vector3(h, 0, v);

        // 스피드 보정
        vector = vector * speed * Time.deltaTime;

        transform.Translate(vector);
    }

    void Jump(){
        if(isJump && canJump){ // && isjump 하고 canjump 가 둘다 true
            rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
            canJump = false;
        }
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.gameObject.name == "Plane"){
            canJump = true;
        }
    }
}
