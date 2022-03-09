using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoNaves : MonoBehaviour
{
   float speed1 = GameDataPersistent.instance.selectedSpaceship.speed;
    Rigidbody2D rigidbody;
    public GameObject projectilePrefab;

    Vector2 lookDirection = new Vector2(1, 0);

    
    void Start()
    {
        Application.targetFrameRate = 30;
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Es la forma de ruby, Pero no se mueve la nave
        /*float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 move = new Vector2(horizontal, vertical);

        if (!Mathf.Approximately(move.x, 0.0f) || !Mathf.Approximately(move.y, 0.0f)) //Verifica que move.x o move.y no sean iguales a 0.  (Indica los maximos y los minimos)
        {
            lookDirection.Set(move.x, move.y); //Si X o Y no son iguales a 0, entonces Ruby se mueve. 
            lookDirection.Normalize();
        }

        Vector2 position = rigidbody.position;

        position = position + move * speed1 * Time.deltaTime;

        rigidbody.MovePosition(position);*/




        if (Input.GetKeyDown(KeyCode.C)) // Disparo Naves
        {
            Launch();

        }

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

    }



    void Launch()
    {
        GameObject projectileObject = Instantiate(projectilePrefab, rigidbody.position + Vector2.up * 0.5f, Quaternion.identity);  //PREGUNTAR: creo que el instantiate es para que la tuerca se mueva con la nave. osea va copiando el chisme en las distintas posiciones

        ProjectileNave projectile = projectileObject.GetComponent<ProjectileNave>();
        projectile.Launch(Vector2.up, 300);

        
        
    }
}
