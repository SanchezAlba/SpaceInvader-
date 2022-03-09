using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileNave : MonoBehaviour
{
    Rigidbody2D rigidbody;

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    public void Launch(Vector2 direction, float force)
    {
        rigidbody.AddForce(direction * force);
    }

    void Update()
    {
        if (transform.position.magnitude > 1000.0f)
        {
            Destroy(gameObject);
        }
    }

    /*void OnCollisionEnter2D(Collision2D other)
    {
       EnemyController e = other.collider.GetComponent<EnemyController>();
        if (e != null)
        {
            
        }

        Destroy(gameObject);
    }*/


}
