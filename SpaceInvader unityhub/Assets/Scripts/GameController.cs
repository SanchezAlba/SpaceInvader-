using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour
{
    public GameObject introScreen;
    public GameObject pantallaEspera;
    public GameObject pantallaInicial;
    public GameObject pulsaAqui;
    public float time = 0f;


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

        time = time + Time.deltaTime; // cuando acabe el texto se cambie la pantalla
        if(time>=41.0f)
        {
            EnablePanatallaEspera();
            DisableIntroScreen();
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
