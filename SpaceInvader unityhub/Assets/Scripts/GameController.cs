using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour
{
    public GameObject introScreen;
    public GameObject pantallaEspera;
    public GameObject pantallaInicial;
    public GameObject pulsaAqui;
 
    public static GameController instance;

    public float time = 0f;


    // Update is called once per frame
    void Update()
    {
       

        time = time + Time.deltaTime; // cuando acabe el texto se cambie la pantalla
        if(time>=41.0f && introScreen.activeSelf==true) //activeSelf es si esta activado o no
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
