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
    float timeToMove = 11f;
    int numOfMovements = 0;
    float speed = 0.025f;

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
                    //Debug.Log(enemiesList[x].enemies[y].name);  //para ver que los comprueba uno a uno
                }

            }
        }
    }


    private void Update()
    {

        ///////// MOVIMIENTO ENEMIGOS ///////
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
                        transform.position += (new Vector3(speed, 0, 0));
                        timer = 0;
                        numOfMovements++;
                    }

                    //cuando choca en on collision

                }

            }
        }


        //CAMBIO DE PANTALLA // //////////////////////////////
        int enemigosVivos = 27;//enemiesList.Length;//0;  //Cuenta los enemigos vivos 
        for (int x = 0; x < enemiesList.Length; x++) //recorre enemilist (la lista de los enemigos en el inspector)
        {
            for (int y = 0; y < enemiesList[x].enemies.Length; y++)  //Para que recorra dentro de las listas(ver los enemigos k hay) .Enemies el nombre dentro de las listas
            {
                if (enemiesList[x].enemies[y].activeSelf == false) //Si est? desactivaado se restan enemigos vivos y al llegar a 0 aparece la pantalla
                {
                    enemigosVivos--;
                }
            }
        }

        //Si lo pongo de la otra forma, que enmigod vivos sea 0, y me vaya restand, tengo que igualar la variable a 0,
        //para que vuekva a contar de sde ahi, si no pasa que en cada vez que lee bucle me pone que hay el dobe de enemigos y asi.

        if (enemigosVivos <= 0) //Si no hay enemigos es que ganaste
        {
            
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
        int randomCol = UnityEngine.Random.Range(0, enemiesList.Length);  //Para que dispare de forma aleatoria -> elige uno al azar de la enemiesLIst (una columna)

        //Buscar en la columna
        GameObject[] columnaAttack = enemiesList[randomCol].enemies; //Creamos esto para no tener que escribir todo eso cada vez.

        //Si est? activo pasa al enemigo de abajo, si no est? activo el sig. entonces el ultmimo es el anterior

        //Si esta activo es el ultimo. Me actualiza la Y
        int row = -1;
        for (int y = 0; y < columnaAttack.Length; y++)  //columan attack aisla el numero que elijo de las listas en el inspector
        {
            if (columnaAttack[y].activeSelf == true)
            {
                row = y; // saca el numero, (el ultimo, el ek va a disparar)

            }


        }

        //Llamamos a atacar
        if (row != -1) //hay que poner -1 pq si no al quedar pocos enemnigos disparan los que estaban desactivados
        {
            columnaAttack[row].GetComponent<EnemyAttack>().Attack(); //Del otro script, con la funcion de disparar  /////// Le dice cual es la columan y con row el k va a disparar
        }

    }


    //  //////////// EXAMEN -> PARA QUE ENCUENTRE AL ?LTIMO _  Bucle para que la bala sepa cual el el ultimo -> Pasar aqui el go de la bala pa que lo detecte
    //if(gameObject1 == enemigoChocado) ->enemigo viene de variable de fuera y G.O de la lista
    // {
    // Degun.Log el enemigo es el mismo que el chocado
    // }

    public void BalaUltimoEnemigo(GameObject enemigoChocado)  //parametros  //INSTANCIA EN BalaSePara
    {
        for (int x = 0; x < enemiesList.Length; x++) //recorre enemilist (la lista de los enemigos en el inspector) //Solo un bucle porque siempre vuscamos mismo elemnto. el de pos 0
        {
           if(enemiesList[x].enemies[0] == enemigoChocado)
            {
                Debug.Log("choca");
                enemigoChocado.SetActive(false);
               
            }
           
        }
    }


    //Esta en el script de DetectorFinal
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


    //Cambio de direccion
    public void ChoqueEnBarrera()
    {
        transform.Translate(new Vector3(0, -0.05f, 0));
        numOfMovements = -1;
        speed = -speed;
        timer = 0;
    }

}
