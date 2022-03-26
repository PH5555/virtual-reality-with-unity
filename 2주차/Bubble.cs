using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubble{ // 공공의
    // 하나의 틀
    // 물풍선 클래스 안에 변수를 생성했다.

    // public으로 선언한 변수는 다른 곳에서 접근할 수 있다.
    // private으로 선언한 변수는 다른곳에서 접근할 수 없다.
    public string color;
    public int range;
    public float damage;

    // 어떤 연산
    public void explode(){
        Debug.Log("펑!");
    }
}