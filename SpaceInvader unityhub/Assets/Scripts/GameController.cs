using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameController : MonoBehaviour
{
    public GameObject introScreen;
    public GameObject pantallaEspera;
    public GameObject pantallaInicial;
    public GameObject pulsaAqui;
    public GameObject pantallaOpciones;
    public GameObject pantallaJugar;
    public GameObject pantallaRecords;

    public float time = 0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

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

    public void EnablePantallaOpciones()
    {
        pantallaOpciones.SetActive(true);
    }
    public void DisablePantallaOpciones()
    {
        pantallaOpciones.SetActive(false);
    }

    public void EnablePantallaJugar()
    {
        pantallaJugar.SetActive(true);
    }
    public void DisablePantllaJugar()
    {
        pantallaJugar.SetActive(false);
       
    }

}
