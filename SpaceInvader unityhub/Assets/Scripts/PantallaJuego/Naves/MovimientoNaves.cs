using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoNaves : MonoBehaviour
{
    float speed1;
    float speedDisparo;

    Rigidbody2D rigidbody;
    public GameObject projectilePrefab;

    //CAMBIOS
    public GameObject projectilePrefab1; //destruye todo
    public GameObject projectilePrefab2; //destruye hasta el ultimo


    public bool boolDisparos = false;

    Vector2 lookDirection = new Vector2(1, 0);

    
    

    void Start()
    {
        Application.targetFrameRate = 30;
        rigidbody = GetComponent<Rigidbody2D>();
        speed1 = GameDataPersistent.instance.selectedSpaceship.speed;
        speedDisparo = GameDataPersistent.instance.selectedSpaceship.heat;
        
    }

    void Update()
    {
        //Debug.Log(speedDisparo);
        speedDisparo -= Time.deltaTime;
        
        
        
       
        ///////////////////////////////////////////////////////

        //Vector3 myMove = Vector3.zero;  //Con esto no funcionaba pq no lo estaba aplicando. hay k aplicarlo al transform.
        //movimiento

        if (Input.GetKey(KeyCode.RightArrow))
         {
             transform.Translate(Vector3.right * Time.deltaTime * speed1, Space.World);
             //myMove += Vector3.right * Time.deltaTime* speed1;
         }

         if (Input.GetKey(KeyCode.LeftArrow))
         {
             transform.Translate(Vector3.left * Time.deltaTime * speed1, Space.World);
             //myMove += Vector3.right * Time.deltaTime * speed1;
         }

        // Tiempo de disparo ///////////////////
        if(speedDisparo <= 0 && Input.GetKeyDown(KeyCode.C))
        {
            Launch();
            boolDisparos = true;
            //timer Heat =10/heat // al dividie el num, si cadencia es 7 va mas rapido que si la cadencia es 1
            //timerHeat es el gamedata persosyent...heat
          
        }

        // ///// Bala que destruye todo
        if (speedDisparo <= 0 && Input.GetKeyDown(KeyCode.Space))
        {
            Launch1();
            boolDisparos = true;
        }

        // ///// Bala que destruye casi todo
        if (speedDisparo <= 0 && Input.GetKeyDown(KeyCode.M))
        {
            Launch2();
            boolDisparos = true;
        }



        if (boolDisparos==true)
        {
            speedDisparo = GameDataPersistent.instance.selectedSpaceship.heat; //para que  el tiempo empice el tiempo
            boolDisparos = false;
            
        }
       
    }


    void Launch()
    {
        GameObject projectileObject = Instantiate(projectilePrefab, rigidbody.position + Vector2.up * 0.5f, Quaternion.identity);  // creo que el instantiate es para que el proyectil se mueva con la nave. osea va copiando el chisme en las distintas posiciones

        ProjectileNave projectile = projectileObject.GetComponent<ProjectileNave>();
        projectile.Launch(Vector2.up, 300);

    }


    //Bala que destruye todo
    public void Launch1() 
    {
        GameObject projectileObject = Instantiate(projectilePrefab1, rigidbody.position + Vector2.up * 0.7f, Quaternion.identity);

        BalaDestruye bala = projectileObject.GetComponent<BalaDestruye>();
        bala.Launch(Vector2.up, 300);

    }


    //Bala se Para al llegar al ult enemigo
    public void Launch2()
    {
        GameObject projectileObject = Instantiate(projectilePrefab2, rigidbody.position + Vector2.up * 0.7f, Quaternion.identity);

        BalaSePara balaPara = projectileObject.GetComponent<BalaSePara>();
        balaPara.Launch(Vector2.up, 300);
    }

}
