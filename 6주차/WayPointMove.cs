using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointMove : MonoBehaviour
{
    public float speed = 1.0f;
    public float rotSpeed = 2.0f;
    Transform[] wayPoints;
    int index = 1;

    void Start()
    {
        GameObject wayPointGroup = GameObject.Find("Way Point");
        wayPoints = wayPointGroup.GetComponentsInChildren<Transform>();
        Debug.Log(wayPoints[1].position);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move(){
        Vector3 direction = wayPoints[index].position - transform.position;
        Quaternion rot = Quaternion.LookRotation(direction);
        transform.Translate(direction * speed * Time.deltaTime);
        transform.rotation = Quaternion.Slerp(transform.rotation, rot, Time.deltaTime * rotSpeed);
    }

    void OnTriggerEnter(Collider other)
    {
        if(index < 2){
            index++;
            
        }
    }
}
