using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantallaEspera : MonoBehaviour
{
    public GameObject introScreen;
    public GameObject pantallaEspera;
    public GameObject pantallaInicial;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey) // al pulsar cualquier tecla cambie la pantalla
        {
            EnablePantallaInicial();
            DisablePantallaEspera();
        }
    }

    public void DisableIntroScreen()
    {
        introScreen.SetActive(false);
    }


    public void EnablePanatallaEspera()
    {
        pantallaEspera.SetActive(true);
    }
    public void DisablePantallaEspera()
    {
        pantallaEspera.SetActive(false);
    }



    public void EnablePantallaInicial()
    {
        pantallaInicial.SetActive(true);
    }
    public void DisablePantallaInicial()
    {
        pantallaInicial.SetActive(false);
    }

}
