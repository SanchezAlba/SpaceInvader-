using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ProjectileNave : MonoBehaviour
{
    Rigidbody2D rigidbody;
    int valorMarcinos = 1;

    //variables de puntos
    int valorPuntos1 = 10;
    int valorPuntos2 = 20;
    int valorPuntos3 = 30;
    int valorPuntosNave = 100;

    //K la nave apareza cuando la matemos
    Vector3 respawn = new Vector3(7,4,0);

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
            ContadorPuntos.puntosActuales += valorPuntos3;
            //ContadorPuntos.puntosAcertados += 1;

        }

        if (other.gameObject.tag == "Marcianos2")
        {
            other.gameObject.SetActive(false);  //Desactivar enemigos
            ContadorPuntos.puntosActuales += valorPuntos2;
            //ContadorPuntos.puntosAcertados += 1;

        }

        if (other.gameObject.tag == "Marcianos3")
        {
            other.gameObject.SetActive(false);  //Desactivar enemigos
            ContadorPuntos.puntosActuales += valorPuntos1;
            //Destroy(other.gameObject); Pa que se destruya el enemigo
            //ContadorPuntos.puntosAcertados += 1;

        }

        if (other.gameObject.tag == "Escudos")
        {
            other.gameObject.SetActive(false);  //Desactivar Escudos
            //ContadorPuntos.puntosDesperdiciados++;
            //ContadorPuntos.puntosActuales = 0;
        }

        if (other.gameObject.tag == "Player")
        {
            other.gameObject.SetActive(false);  //Desactivar Enemigos
                                                //Para k al matar la nave aparezaca en X posicion //other.gameObject.transform.position = respawn;
            Debug.Log("Perdiste");
        }

        if(other.gameObject.tag =="NaveNodriza")
        {
            other.gameObject.SetActive(false);
            ContadorPuntos.puntosActuales += valorPuntosNave;
        }

        if (other.gameObject.tag == "Barrera")
        {
            //ContadorPuntos.puntosActuales = 0;
            //ContadorPuntos.puntosDesperdiciados++;
        }



        Destroy(gameObject); //Para que el proyectil al chocarse se elimine
    }

}
