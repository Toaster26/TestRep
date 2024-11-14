using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEx : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("충돌발생: " + collision.gameObject.name);
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("트리거 진입: " + other.gameObject.name);
    }
    void OnCollisionStay(Collision collision)
    {
        Debug.Log("충돌 중: " + collision.gameObject.name);
    }
    void OnCollisionExit(Collision collision)
    {
        Debug.Log("충돌 종료: " + collision.gameObject.name);
    }
}
