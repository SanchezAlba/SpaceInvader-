using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoviminetoEnemigo : MonoBehaviour
{

    private float speedBall = 8.0f;
    Vector3 movHorizontal = Vector3.right;
    Vector3 movVertical = Vector3.up;

    public static MoviminetoEnemigo instance;

  
    private void Update()
    {
        transform.position += (movHorizontal) * Time.deltaTime * speedBall;

        //Para k baje
        //timer += Time.deltaTime;
        /*if(timer > timeToMove)
        {
            transform.Translate(new Vector2(0, -1));
            numOfMovements = -1;
            speed = -speed;
            timer = 0;
        }*/


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Barrera")  //Cuando colisiona, el game object con ese tag, hará tal cosa
        {
            movHorizontal = -movHorizontal;
        }

    }

}
