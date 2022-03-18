using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContadorPuntos : MonoBehaviour
{
    public TextMeshProUGUI contador;
    public TextMeshProUGUI totalPuntos;

    public static int puntosActuales =0;

    void Update()
    {
        contador.text = puntosActuales.ToString();
        totalPuntos.text = puntosActuales.ToString();
    }
}
