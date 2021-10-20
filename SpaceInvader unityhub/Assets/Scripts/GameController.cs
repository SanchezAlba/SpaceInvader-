using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour
{
    public GameObject introScreen;
    public GameObject pantallaEspera;
    public GameObject pantallaInicial;
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

    void EnablePanatallaEspera()
    {
        pantallaEspera.SetActive(true);
    }
    void DisablePantallaEspera()
    {
        pantallaEspera.SetActive(false);
    }

    void DisableIntroScreen()
    {
        introScreen.SetActive(false);
    }

    void EnablePantallaInicial()
    {
        pantallaInicial.SetActive(true);
    }
    void DisablePantallaInicial()
    {
        pantallaInicial.SetActive(false);
    }
}
