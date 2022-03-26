using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class day2 : MonoBehaviour // 상속한다.
{
    //초기화 부분 
    //awake 하고 start는 단 한번밖에 실행이 안된다. - 공통점
    //awake 게임 오브젝트가 생성될 때 실행 - awake 가 먼저 실행된다. 활성화가 되어있지 않아도 실행됨
    //start는 업데이트 시작 직전 실행 - 활성화가 되어있지 않으면 실행안됨.
    void Awake() // 얘가 좋음 - awake 끼리는 누가 먼저 실행될지 몰라요
    // 오브젝트끼리 변수를 참조하고 싶은데 누가먼저 실행될지 몰라요
    {
        Debug.Log("awake");
    }

    void Start()
    // 다른 오브젝트의 변수를 참조하고 싶을 때
    {
        Debug.Log("start");

        // 자료형 변수의 이름;
        // 변수를 선언했다.
        // 초기화를 하지않으면 쓰레기값이 들어감
        int e;

        // 초기화를 했다.
        e = 3;

        // 변수의 선언과 초기화를 동시에 했다.
        int a = 3;

        //float 는 실수 f 붙여주기
        float b = 3.4f;
        bool c = true;
        string d = "hello";

        // ---------------------------------

        string name1 = "golem";
        string name2 = "slime";
        string name3 = "mushroom";
       // 자료형[] 변수 이름 = { 넣어주고 싶은 데이터 };
        string[] names = {"골렘", "슬라임", "주황버섯"};

        // 메모리에 이 배열을 만들겠다.
        // 자료형[] 변수이름 = new 자료형[상수]{ 넣어주고 싶은 데이터 }
        string[] monsters = new string[3]{"골렘", "슬라임", "주황버섯"};

        names[1] = null;


        // 데이터를 넣고 빼기가 쉽다. 배열은 어렵다.

        //List<자료형> 변수이름 = new List<자료형>();
        List<string> monsterNames = new List<string>();

        monsterNames.Add("슬라임");
        monsterNames.Add("골렘");
        monsterNames.Add("주황버섯");

        monsterNames.RemoveAt(0);

        //---------------------------------------------

        // foreach (자료형 변수이름 in 만들었던 그룹형변수)

        // monsters 안에 들어있는 요소를 모두 탐색해준다.
        // 0번째 일때 monster 0번째 요소가 들어가고
        // 1번째 일때 monster 1번째 요소각 들어가고 
        // ,,,,
        foreach (string monster in monsterNames)
        {
            // Debug.Log(monster);
        }

        //------------------------------------------------
        

        // 클래스 이름 변수이름 = new 클래스 이름();
        // 생성자
        Bubble bubble = new Bubble();

        bubble.color = "오로라색";
        bubble.damage = 20;
        bubble.range = 4;

        // bubble.explode();

        Cat cat = new Cat();
        // cat.howling();


    }

    // 1초에 여러번 실행이 됨
    void FixedUpdate() // 물리연산에 최적화되어있음 - 충돌연산
    // 1초에 실행되는 수가 정해져있다.
    // cpu를 많이 잡아먹는다.
    {
        // Debug.Log("fixedUpdsate");
    }

    void Update() // 게임 로직 : 사용자가 키보드를 누르는지 확인해야 돼
    // 1초에 실행되는 수가 정해져있지않다.
    // 사용자의 컴퓨터 환경에 따라 달라져요
    // 불규칙한 연산이기 때문에 물리연산에 적합하지 않음.
    {
        // Debug.Log("update");
    }

    void LateUpdate()
    // update가 실행되고 난 후에 바로 실행됨.
    // update에서 게임연산을 실행하고 후처리, 카메라 이동
    {
        // Debug.Log("lateupdate");
        
    }

    void OnDestroy()
    // 오브젝트가 해체될 때 실행됨.
    {
        Debug.Log("ondestroy");
        
    }

    void OnEnable() // 활성화 할 때마다 초기화 줄 필요가 있을 때
    {
        Debug.Log("onenable");
        
    }

    void OnDisable()
    {
        Debug.Log("onndisable");
        
    }

}
