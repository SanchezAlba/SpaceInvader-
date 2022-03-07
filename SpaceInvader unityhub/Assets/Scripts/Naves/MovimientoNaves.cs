using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoNaves : MonoBehaviour
{
   float speed1 = GameDataPersistent.instance.selectedSpaceship.speed;
    Rigidbody rigidbody;
    public GameObject projectilePrefab;

    void Start()
    {
        Application.targetFrameRate = 30;
        rigidbody = GetComponent<Rigidbody>();

    }

    void Update()
    {


        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 position = rigidbody.position;
        position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        

        rigidbody.MovePosition(position);

        if (Input.GetKeyDown(KeyCode.C)) // Disparo Naves
        {
            Launch();
        }

        ///////////////////////////////////////////////////////

        //Vector3 myMove = Vector3.zero;  //Con esto no funcionaba pq no lo estaba aplicando. hay k aplicarlo al transform.  

        /* if (Input.GetKey(KeyCode.RightArrow))
         {
             transform.Translate(Vector3.right * Time.deltaTime * speed1, Space.World);
             //myMove += Vector3.right * Time.deltaTime* speed1;
         }

         if (Input.GetKey(KeyCode.LeftArrow))
         {
             transform.Translate(Vector3.left * Time.deltaTime * speed1, Space.World);
             //myMove += Vector3.right * Time.deltaTime * speed1;
         }*/

    }



    void Launch()
    {
        /*GameObject projectileObject = Instantiate(projectilePrefab, rigidbody.position + Vector2.up * 0.5f, Quaternion.identity);

        ProjectileNave projectile = projectileObject.GetComponent<ProjectileNave>();
        projectile.Launch(lookDirection, 300);*/

        
    }
}
