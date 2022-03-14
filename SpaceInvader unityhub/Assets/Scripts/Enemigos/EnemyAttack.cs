using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    Rigidbody2D rigidbody;

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    

  /* public void Attack(Vector2 down, float force)
    {
        rigidbody.AddForce(down * force);
    }*/

    public void Attack() //misma funcion de ataque, poner scripot en l empty con los enemigos y eaqui se poine el proyectil
    {
        
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
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.SetActive(false);  //Desactivar Naves
        }

        Destroy(gameObject); //Para que el proyectil al chocarse se elimine

    }

}
