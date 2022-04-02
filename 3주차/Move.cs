using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // 캡슐화에 위반되기 때문에 public 을 쓰지 않는다
    // 유니티에서도 볼 수 있고, 스트립트간에서도 볼 수 있다.

    // 유니티에서도 볼 수 있고, 스트립트간에서는 볼 수 없다.
    [SerializeField]
    int speed = 10;

    float h;
    float v;
    // Start is called before the first frame update
    void Start()
    {
        // transform.position = new Vector3(5, 0, 0);

        // 이거 만큼 움직인다

        // transform.position += new Vector(5,0,0);
        // transform.Translate(new Vector3(5,0,0));
    }

    // Update is called once per frame
    void Update() // 매 프레임 실행 됨
    {
        // 누르고 있을 때의 이벤트
        // if(Input.GetKey(KeyCode.A)){ // T 로 바꾸고 싶다.
        //     transform.Translate(new Vector3(1,0,0));
        // }

        // if(Input.GetKeyDown(KeyCode.A)){
        //     Debug.Log("A가 눌리기 시작했습니다");
        // }

        // if(Input.GetKeyUp(KeyCode.A)){
        //     Debug.Log("A가 떼졌습니다");
        // }

        // if(Input.GetButton("Horizontal")){
        //     Debug.Log("방향키 눌림");
        // }

        // 부드럽게 -1 1 까지 반환을 하는 함수
        // Debug.Log(Input.GetAxis("Horizontal"));

        // -1 1 까지 반환을 하는 함수
        // Debug.Log(Input.GetAxisRaw("Horizontal"));

        // 델타타임을 곱하면 이동거리를 공평하게 할 수 있다.
        GetInput();
        Movement();
    }

    void GetInput(){
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
    }

    void Movement(){
        Vector3 vector = new Vector3(h, 0, v);

        // 스피드 보정
        vector += vector * speed * Time.deltaTime;

        transform.Translate(vector);
    }
}
