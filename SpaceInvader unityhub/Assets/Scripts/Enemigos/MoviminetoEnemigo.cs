using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoviminetoEnemigo : MonoBehaviour
{
    //El mov en el escript enemy controller, creamos funcion, con 2 bucles for /(update)
    // por ej: cada 1 segundo se muevan una casilla


    float timer = 0;
    float timeToMove = 0.5f;
    int numOfMovements = 0;
    float speed = 0.25f;

    private void Update()
    {
        //mover pa abajo despues de X moviminetos
        if(numOfMovements == 10)
        {
            transform.Translate(new Vector3(0, -1, 0));
            numOfMovements = -1;
            speed = -speed;
            timer = 0;
        }


        //Mov pal lado
        timer += Time.deltaTime;
        if(timer > timeToMove && numOfMovements <10)
        {
            transform.Translate(new Vector3(speed, 0, 0));
            timer = 0;
            numOfMovements++;
        }
    }

 

}
