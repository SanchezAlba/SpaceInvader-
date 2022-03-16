using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovNaveNodriza : MonoBehaviour
{
    float speed = 10f;
    float maxLeft = -33;
    float timer;


    void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime); //Por no se k motivo, al poner left va pa bajo y al poner up va a la izq

        if(transform.position.x<= maxLeft) //Si la posicion de X es menor o igual a max left se destruye la nave
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }
}
