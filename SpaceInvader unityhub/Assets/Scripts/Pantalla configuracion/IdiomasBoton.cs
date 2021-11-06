using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdiomasBoton : MonoBehaviour
{
    public GameObject flechaDcha;
    public GameObject flechaIzq;

    public GameObject españa;
    public GameObject england;


    public void flechaDerecha()
    {
        españa.SetActive(false);
        england.SetActive(true);
    }

    public void flechaIzquierda()
    {
        españa.SetActive(true);
        england.SetActive(false);
    }

}
