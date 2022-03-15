using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    
    public GameObject balaEnemigo;
    Vector2 lookDirection = new Vector2(0, -1);
    Rigidbody2D rigidbodyEnemigo;

    void Awake()
    {
        rigidbodyEnemigo = GetComponent<Rigidbody2D>();
    }

    

  /* public void Attack(Vector2 down, float force)
    {
        rigidbody.AddForce(down * force);
    }*/

    public void Attack() //misma funcion de ataque, poner scripot en l empty con los enemigos y eaqui se poine el proyectil
    {
        GameObject projectileObject = Instantiate(balaEnemigo, rigidbodyEnemigo.position + Vector2.down * 0.5f, Quaternion.identity);
        ProjectileNave projectile = projectileObject.GetComponent<ProjectileNave>();
        projectile.Launch(Vector2.down, 300);
    }

    /*void Update()
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

    }*/

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.SetActive(false);  //Desactivar Naves

        }

        if (other.gameObject.tag == "Escudos")
        {
            other.gameObject.SetActive(false);  //Desactivar Escudos
        }

        Destroy(gameObject); //Para que el proyectil al chocarse se elimine

    }

}
