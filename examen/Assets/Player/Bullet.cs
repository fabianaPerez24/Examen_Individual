using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    private Vector3 direction;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        Destroy(gameObject, 3f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
    public void SetDirection(Vector3 direction)
    {
        this.direction = direction;
    }
    void Update()
    {

        rb.velocity = direction * speed; 
    }

}
