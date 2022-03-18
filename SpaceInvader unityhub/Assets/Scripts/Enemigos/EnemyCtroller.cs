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


    //Variables de ataque
    float timeEnemigo;
    bool disparoEnemigo = false;

    //Variables nave nodriza
    Vector2 naveNodrizaPos = new Vector2(33f, 16.45f);
    public GameObject naveNodriza;
    float timerNaveNodriza = 10;
    float timerNodrizaMin = 10;
    float timerNodrizaMax = 20;

    //variables mov. Enemigos
    float timerMov=1;

    // Para pasar de pantalla
    public bool hasWon = false;
    public GameObject pantallaGanaste;
    public GameObject pantallaJuego;
    //public static int enemigosVivos = 0;

    private void start()
    {
        PrintArray();
        //pantallaGanaste.SetActive(false);
    }

    void PrintArray()
    {
        for (int x = 0; x < enemiesList.Length; x++) //recorre enemilist (la lista de los enemigos en el inspector)
        {
            for (int y = 0; y < enemiesList[x].enemies.Length; y++)  //Para que recorra dentro de las listas(ver los enemigos k hay) .Enemies el nombre dentro de las listas
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
        //Pantalla ganaste
        /*if(hasWon == true)
        {
            pantallaGanaste.SetActive(true);
            pantallaJuego.SetActive(false);
        }*/

        //Cambio de pantalla // ////////////////////////////////////////////////////////////////////////////////
        int enemigosVivos = 27;//enemiesList.Length;//0;  //Cuenta los enemigos vivos 
        for (int x = 0; x < enemiesList.Length; x++) //recorre enemilist (la lista de los enemigos en el inspector)
        {
            for (int y = 0; y < enemiesList[x].enemies.Length; y++)  //Para que recorra dentro de las listas(ver los enemigos k hay) .Enemies el nombre dentro de las listas
            {

                if (enemiesList[x].enemies[y].activeSelf == false) //Si está activo -> Se suman los enemigos vivos
                {
                    enemigosVivos--;
                }
            }
        }

        if (enemigosVivos <= 0) //Si no hay enemigos es que ganaste
        {
            Debug.Log("Ganaste!!!");
            pantallaGanaste.SetActive(true);
        }
        else
        {
            timeEnemigo -= Time.deltaTime;
            timerNaveNodriza -= Time.deltaTime;

            // Nave nodriza
            if (timerNaveNodriza <= 0)
            {
                SpawnNaveNodriza();
            }

            if (timeEnemigo <= 0)
            {
                disparoEnemigo = true;
                Attack();
            }
            if (disparoEnemigo == true)
            {
                timeEnemigo = 2f;
                disparoEnemigo = false;
            }
        }
        

        


        // /////////////////////  lo de clase, k al darle al espacio se borrase el ult enemigo
       //if (Input.GetKeyUp(KeyCode.Space))
        //{
            //cuando encuentre a alguien descatvado para la busqueda ->
            /*int lastx = enemiesList.Length-1; //lo ult activo
            int lastY = enemiesList[lastx].enemies.Length-1;
            bool foundLastActive = false; //saber si esta activo 
                                          //Aqui nuevo bucle que calcula ult. X e Y

            for (int x = 0; x < enemiesList.Length; x++) //recorre enemilist (la lista de los enemigos en el inspector)
            {
                for (int y = 0; y < enemiesList[x].enemies.Length; y++)  //Para que recorra dentro de las listas(ver los enemigos k hay) .Emeies el nombre dentro de las listas
                {

                    if (enemiesList[x].enemies[y].activeSelf == false && foundLastActive ==false) //este para la busqueda
                    {

                        foundLastActive = true; //encontre al ultimo, que esta muerto y para de buscar

                        Debug.Log(enemiesList[x].enemies[y].name);  //para ver que los comprueba uno a uno
                    }

                    else if(enemiesList[x].enemies[y].activeSelf ==true && foundLastActive == false) //Dice cual es el ultimo activo _ todo esta activo, y no encontyro al ultimo
                    {
                        lastx = x; //establece como ultimo a la ultima x y ulti Y
                        lastY = y;
                    }

                }
            }

            //enemiesList[lastx].enemies[enemiesList[lastx].enemies.Length - 1].SetActive(true);
            enemiesList[lastx].enemies[lastY].SetActive(false); //ult x Y se vuelve falso al pulsar espacio
            PrintArray();
       // }*/

       

    }

    //Mov nave nodriza
    public void SpawnNaveNodriza()
    {
        Instantiate(naveNodriza, naveNodrizaPos, Quaternion.identity);
        timerNaveNodriza = UnityEngine.Random.Range(timerNodrizaMin, timerNodrizaMax); //El tiempo de nave nodriza es = a un numero aleatorio entre num min y max

        naveNodriza.SetActive(true);
        naveNodriza.transform.localPosition = new Vector2(9f, 5.18f);
    }
            
    ///////////// DISPARO ENEMIGOS
    public void Attack()
    {
        //Selec columna
        int randomCol = UnityEngine.Random.Range(0, enemiesList.Length);  //Para que dispare de forma aleatoria

        //Buscar en la columna
        GameObject[] columnaAttack = enemiesList[randomCol].enemies; //Creamos esto para no tener que escribir todo eso cada vez.


        //Si esta activo es el ultimo. Me actualiza la Y
        int row = -1;
        for(int y=0;y< columnaAttack.Length;y++)  //columan attack aisla el numero que elijo de las listas en el inspector
        {
            if(columnaAttack[y].activeSelf == true)
            {
                row = y; // saca el numero, (el ultimo, el ek va a disparar)

            }

            //Para pasar de pantalla
            /*else if(columnaAttack[y].activeSelf == false)
            {
                hasWon = true;
            }*/
        }

        //Llamamos a atacar
        if(row != -1)
        {
            columnaAttack[row].GetComponent<EnemyAttack>().Attack(); //Del otro script, con la funcion de disparar  /////// Le dice cual es la columan y con row el k va a disparar
        }
        
    }


    void OnCollisionEnter2D(Collision2D other) //no hace nada
    {
        if (other.gameObject.tag == "Escudos")
        {
            other.gameObject.SetActive(false);  //Desactivar escudos

        }
   

    }
}
