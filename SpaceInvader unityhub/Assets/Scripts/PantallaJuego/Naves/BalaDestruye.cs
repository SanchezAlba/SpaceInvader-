using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaDestruye : MonoBehaviour
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



    private void OnTriggerEnter2D(Collider2D other)   //Trigger para que no pierda velocidad la bala
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

        }

        if (other.gameObject.tag == "BalaEnemigo")
        {
            other.gameObject.SetActive(false);

        }
    }
    //launch() para que la vuelva a empujar //o trnasform.position ->para que no pare


}
