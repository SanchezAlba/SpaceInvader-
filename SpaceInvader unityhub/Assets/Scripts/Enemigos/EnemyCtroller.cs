using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class EnemyCtroller : MonoBehaviour
{
    [Serializable]
    public class EnemiesList
    {
        public GameObject[] enemies;
    }
    public EnemiesList[] enemiesList;

    public int columna;  //Ir mirando por culumnas. y de ahi num aleartorio

    Rigidbody2D rigidbody;

    private void Start()
    {
        columna = UnityEngine.Random.Range(20, 170);
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
       
        if (Input.GetKeyUp(KeyCode.Space))
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


    ///////////// DISPARO ENEMIGOS
    void Attack()
    {
        //Selec columna
        int randomCol = UnityEngine.Random.Range(0, enemiesList.Length);  //Para que dispare de forma aleatoria

        //Buscar en la columna
        GameObject[] columnaAttack = enemiesList[randomCol].enemies;


        //Si esta activo es el ultimo. Me actualiza la Y
        int row = 0;
        for(int y=0;y< columnaAttack.Length;y++)  //columan attack aisla el numero que eligio de las listas en el inspector
        {
            if(columnaAttack[y].activeSelf == true)
            {
                row = y; // saca el numero, (el ultimo, el ek va a disparar)
            }
        }

        //Llamamos a atacar
        columnaAttack[row].GetComponent<EnemyAttack>().Attack(); //Del otro script, con la funcion de disparar  /////// Le dice cual es la columan y con row el k va a disparar
    }

   
}
