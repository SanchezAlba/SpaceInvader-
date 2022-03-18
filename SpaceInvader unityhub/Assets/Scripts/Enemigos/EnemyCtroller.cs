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

    // Variables mov. Enemigos
    float timer = 0;
    float timeToMove = 0.5f;
    int numOfMovements = 0;
    float speed = 0.0025f;

    // Para pasar de pantalla
    public GameObject pantallaGanaste;
    public GameObject pantallaJuego;

    public static EnemyCtroller instance;
    void Start()
    {
        instance = this;
        PrintArray();
       pantallaGanaste.SetActive(false);
    }

    void PrintArray()
    {
        for (int x = 0; x < enemiesList.Length; x++) //recorre enemilist (la lista de los enemigos en el inspector)
        {
            for (int y = 0; y < enemiesList[x].enemies.Length; y++)  //Para que recorra dentro de las listas(ver los enemigos k hay) .Enemies el nombre dentro de las listas por eso esta linea revisa las columnas
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

        ////////////Movimiento enemios  ///////
        //mover pa abajo despues de X moviminetos
        for (int x = 0; x < enemiesList.Length; x++) //recorre enemilist (la lista de los enemigos en el inspector)
        {
            for (int y = 0; y < enemiesList[x].enemies.Length; y++)  //Para que recorra dentro de las listas(ver los enemigos k hay) .Enemies el nombre dentro de las listas
            {
                if (enemiesList[x].enemies[y].activeSelf == true)
                {
                    timer += Time.deltaTime;
                    if (timer > timeToMove)
                    {
                        transform.Translate(new Vector3(speed, 0, 0));
                        timer = 0;
                        numOfMovements++;
                    }

                    //cuando choca en on collision
                   
                }

            }
        }


        //Cambio de pantalla // //////////////////////////////
        int enemigosVivos = 27;//enemiesList.Length;//0;  //Cuenta los enemigos vivos 
        for (int x = 0; x < enemiesList.Length; x++) //recorre enemilist (la lista de los enemigos en el inspector)
        {
            for (int y = 0; y < enemiesList[x].enemies.Length; y++)  //Para que recorra dentro de las listas(ver los enemigos k hay) .Enemies el nombre dentro de las listas
            {

                if (enemiesList[x].enemies[y].activeSelf == false) //Si está desactivaado se restan enemigos vivos y al llegar a 0 aparece la pantalla
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


    public void OnCollisionEnter2D(Collision2D other) //no hace nada
    {
        if (other.gameObject.tag == "Escudos")
        {
            other.gameObject.SetActive(false);  //Desactivar escudos
        }

        //Movimiento al chocar
        if (other.gameObject.tag == "Barrera")
        {
            transform.Translate(new Vector3(0, -1, 0));
            numOfMovements = -1;
            speed = -speed;
            timer = 0;
        }
    }

    public void ChoqueEnBarrera()
    {
        transform.Translate(new Vector3(0, -0.05f, 0));
        numOfMovements = -1;
        speed = -speed;
        timer = 0;
    }

}
