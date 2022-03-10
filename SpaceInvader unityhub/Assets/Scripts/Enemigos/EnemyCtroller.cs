using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemyCtroller : MonoBehaviour
{
    [Serializable]
    public class EnemiesList
    {
        public GameObject[] enemies;
    }
    public EnemiesList[] enemiesList;

    private void Start()
    {
        PrintArray();
    }

    void PrintArray()
    {
        for (int x = 0; x < enemiesList.Length; x++) //recorre enemilist (la lista de los enemigos en el inspector)
        {
            for (int y = 0; y < enemiesList[x].enemies.Length; y++)  //Para que recorra dentro de las listas(ver los enemigos k hay) .Emeies el nombre dentro de las listas
            {

                if (enemiesList[x].enemies[y].activeSelf == true)
                {
                    Debug.Log(enemiesList[x].enemies[y].name);  //para ver que los comprueba uno a uno
                }

            }
        }
    }


    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            //cuando encuentre a alguien descatvado para la busqueda ->
            int lastx = enemiesList.Length-1; //lo ult activo
            int lastY = enemiesList[lastx].enemies.Length-1;
            bool foundLastActive = false; //saber si esta activo 
                                          //Aqui nuevo bucle que calcula ult. X e Y

            for (int x = 0; x < enemiesList.Length; x++) //recorre enemilist (la lista de los enemigos en el inspector)
            {
                for (int y = 0; y < enemiesList[x].enemies.Length; y++)  //Para que recorra dentro de las listas(ver los enemigos k hay) .Emeies el nombre dentro de las listas
                {

                    if (enemiesList[x].enemies[y].activeSelf == false && foundLastActive ==false) //este para la busqueda
                    {

                        foundLastActive = true;

                        Debug.Log(enemiesList[x].enemies[y].name);  //para ver que los comprueba uno a uno
                    }

                    else if(enemiesList[x].enemies[y].activeSelf ==true && foundLastActive == false) //Dice cual es el ultimo activo
                    {
                        lastx = x;
                        lastY = y;
                    }

                }
            }

            //enemiesList[lastx].enemies[enemiesList[lastx].enemies.Length - 1].SetActive(true);
            enemiesList[lastx].enemies[lastY].SetActive(false);
            PrintArray();
        }
    }


    ///////////// OCULTAR EL MARCIANO AL DARLE EL RAYO
    ///
    /*private void OnTriggerEnter(Collider other)  //
    {
        if (other.tag == "Rayo")  //para que solo la pueda coger el objeto con el tag PLAYER
        {
            gameObject.SetActive(false); //El marciano desaparece
           
        }

    }*/

   /* void OnCollisionEnter2D(Collision2D other)
    {
       if(other.tag=="Rayo")
            {
            gameObject.SetActive(false);
        }

    }*/

}
