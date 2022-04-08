using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaSePara : MonoBehaviour
{
    Rigidbody2D rigidbody;

    void Awake()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

   

    public void Launch(Vector2 up, float force)
    {
        rigidbody.AddForce(up * force);
    }


    public void ChoqueBala()
    {
        EnemyCtroller.instance.BalaUltimoEnemigo(gameObject);
        Debug.Log("Se choca");
        //que devuelva valor

        

    }


    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Marcianos")
        {
            other.gameObject.SetActive(false);

        }

        if (other.gameObject.tag == "Marcianos2")
        {
            other.gameObject.SetActive(false);

        }

        if (other.gameObject.tag == "Marcianos3")
        {
            other.gameObject.SetActive(false);


        }


        if (other.gameObject.tag == "NaveNodriza")
        {
            other.gameObject.SetActive(false);

        }

        if (other.gameObject.tag == "Barrera")
        {
            Destroy(gameObject);
        }

        if (other.gameObject.tag == "Escudos")
        {
            other.gameObject.SetActive(false);
            Destroy(gameObject);

        }

        if (other.gameObject.tag == "BalaEnemigo")
        {
            other.gameObject.SetActive(false);

        }

        
    }
}
