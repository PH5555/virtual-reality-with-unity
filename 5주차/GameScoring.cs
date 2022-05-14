using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScoring : MonoBehaviour
{
    public int score = 0;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.gameObject.tag == "Finish"){
            score++;
            Destroy(collisionInfo.gameObject);
        }
    }
}
