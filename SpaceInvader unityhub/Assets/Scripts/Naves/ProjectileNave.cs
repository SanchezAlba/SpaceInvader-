using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ProjectileNave : MonoBehaviour
{
    Rigidbody2D rigidbody;
    int valorMarcinos = 1;

    

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
    
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
        if (other.gameObject.tag == "Marcianos") 
        {
         other.gameObject.SetActive(false);  //Desactivar enemigos
                                             // GetComponent<PlayerPoints>().AddPoints();


        }

        if (other.gameObject.tag == "Escudos")
        {
            other.gameObject.SetActive(false);  //Desactivar Escudos
        }

        

        Destroy(gameObject); //Para que el proyectil al chocarse se elimine
    }

}
