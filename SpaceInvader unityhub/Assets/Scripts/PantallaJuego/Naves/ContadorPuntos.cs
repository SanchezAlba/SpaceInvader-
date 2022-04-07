using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContadorPuntos : MonoBehaviour
{
    public TextMeshProUGUI contador;
    public TextMeshProUGUI totalPuntos;

    public TextMeshProUGUI labelPuntosDesperdiciados;
    public static int puntosDesperdiciados = 0;

    public TextMeshProUGUI labelPuntosAcertador;
    public static int puntosAcertados = 0;

    public static int puntosActuales =0;
    public TextMeshProUGUI puntosPerdiste;

    void Update()
    {
        contador.text = puntosActuales.ToString();
        totalPuntos.text = puntosActuales.ToString();
        puntosPerdiste.text = puntosActuales.ToString();

        labelPuntosDesperdiciados.text = "Puntos Desperdiciados    " + puntosDesperdiciados.ToString();
        labelPuntosAcertador.text = "Puntos Acertados   " + puntosAcertados.ToString();

    }
    void AddPoint(int puntosenemigo)
    {
        //points = untos enemigp
        //(destoy gameobject)
    }
}
