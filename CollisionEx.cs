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
        Debug.Log("�浹�߻�: " + collision.gameObject.name);
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Ʈ���� ����: " + other.gameObject.name);
    }
    void OnCollisionStay(Collision collision)
    {
        Debug.Log("�浹 ��: " + collision.gameObject.name);
    }
    void OnCollisionExit(Collision collision)
    {
        Debug.Log("�浹 ����: " + collision.gameObject.name);
    }
}
