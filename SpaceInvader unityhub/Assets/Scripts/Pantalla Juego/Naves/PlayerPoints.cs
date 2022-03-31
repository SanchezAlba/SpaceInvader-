using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerPoints : MonoBehaviour
{
    int puntosActuales = 0;
    public TextMeshProUGUI labelPuntos;

    public static PlayerPoints instance;

    void Start()
    {
        labelPuntos.text = "Points";
    }


    public void AddPoints(int cantidadObtenida)
    {
        puntosActuales += 1;
        labelPuntos.text = puntosActuales.ToString();
    }

}
