using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoNaves : MonoBehaviour
{
    float speed1;
    float speedDisparo;

    Rigidbody2D rigidbody;
    public GameObject projectilePrefab;
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
        Debug.Log(speedDisparo);
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
          
        }
        
        if(boolDisparos==true)
        {
            speedDisparo = GameDataPersistent.instance.selectedSpaceship.heat;
            boolDisparos = false;
            
        }
       
    }


    void Launch()
    {
        GameObject projectileObject = Instantiate(projectilePrefab, rigidbody.position + Vector2.up * 0.5f, Quaternion.identity);  // creo que el instantiate es para que el proyectil se mueva con la nave. osea va copiando el chisme en las distintas posiciones

        ProjectileNave projectile = projectileObject.GetComponent<ProjectileNave>();
        projectile.Launch(Vector2.up, 300);

    }
}
