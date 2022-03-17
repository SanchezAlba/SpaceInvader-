using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoviminetoEnemigo : MonoBehaviour
{

    private float speed = 8.0f;
    Vector3 movHorizontal = Vector3.right;
    Vector3 movVertical = Vector3.down;

    public static MoviminetoEnemigo instance;

    void Start()
    {
        if (MoviminetoEnemigo.instance == null)
        {
            MoviminetoEnemigo.instance = this;
        }

        else
        {
            Destroy(this);
        }

    }

    void Update()
    {
        transform.position += (movHorizontal) * Time.deltaTime * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Barrera")  //Cuando colisiona, el game object con ese tag, hará tal cosa
        {

            movHorizontal = -movHorizontal;
        }


        //El mov en el escript enemy controller, creamos funcion, con 2 bucles for /(update)
        // por ej: cada 1 segundo se muevan una casilla

    }

}
