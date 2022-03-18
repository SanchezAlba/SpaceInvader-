using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectorFinal : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Movimiento al chocar
        if (collision.gameObject.tag == "Barrera")
        {
            EnemyCtroller.instance.ChoqueEnBarrera();

        }
    }
}
