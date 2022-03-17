using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContadorPuntos : MonoBehaviour
{
    public TextMeshProUGUI contador;
    public static int puntosActuales =0;

    void Update()
    {
        contador.text = puntosActuales.ToString();
    }
}
