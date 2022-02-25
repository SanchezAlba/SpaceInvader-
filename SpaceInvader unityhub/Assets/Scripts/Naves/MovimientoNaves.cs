using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoNaves : MonoBehaviour
{
    public float speed1 = 3f;


    void Start()
    {
        Application.targetFrameRate = 30;
    }

    
    void Update()
    {
        //Vector3 myMove = Vector3.zero;  //Con esto no funcionaba pq no lo estaba aplicando. hay k aplicarlo al transform.  
        
        //HAcer el movimiento como en ruby -> dice k queda mejor k esto

        if(Input.GetKey(KeyCode.RightArrow))
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
}
