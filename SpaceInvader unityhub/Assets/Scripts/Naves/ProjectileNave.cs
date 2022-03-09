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

    public void Launch(Vector2 up, float force)
    {
        rigidbody.AddForce(up * force);
    }

    void Update()
    {
        if (transform.position.magnitude > 1000.0f)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
       /*EnemyController e = other.collider.GetComponent<EnemyController>();
        if (e != null)
        {
            
        }*/

        Destroy(gameObject); //Para que el proyectil al chocarse se elimine

    
    }

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Marcianos")
        {
            gameObject.SetActive(false);
        }
    }*/
}
