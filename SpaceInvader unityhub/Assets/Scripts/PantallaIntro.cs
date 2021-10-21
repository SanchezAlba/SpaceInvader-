using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantallaIntro : MonoBehaviour
{
    public GameObject introScreen;
    public GameObject pantallaEspera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space)==true)
        {
            DesactivarIntroScreen();
            ActivarPantallaEspera();
        }
    }

    void ActivarPantallaEspera()
    {
        pantallaEspera.SetActive(true);
    }

    void DesactivarIntroScreen()
    {
        introScreen.SetActive(false);
    }
}
