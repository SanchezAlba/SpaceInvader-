using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdiomasBoton : MonoBehaviour
{
    public GameObject flechaDcha;
    public GameObject flechaIzq;

    public GameObject espa�a;
    public GameObject england;


    public void flechaDerecha()
    {
        espa�a.SetActive(false);
        england.SetActive(true);
    }

    public void flechaIzquierda()
    {
        espa�a.SetActive(true);
        england.SetActive(false);
    }

}
