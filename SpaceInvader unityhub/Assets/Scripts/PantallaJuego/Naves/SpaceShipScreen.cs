using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

using UnityEngine.SceneManagement;

public class SpaceShipScreen : MonoBehaviour
{
    public TextMeshProUGUI labelNameShip;
    public SpashipData[] infoSpaceShip;
    public GameObject[] modelosNaves;
    public GameObject[] caracteristicasNaves;

    /*public GameObject nave1;
    public GameObject nave2;
    public GameObject nave3;*/

    public int index = 0;

    public Slider speedSlider;
    public Slider shieldSlider;
    public Slider heatSlider;

    private float speed = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(infoSpaceShip[index].speed);
        Debug.Log(infoSpaceShip[index].shield);
        Debug.Log(infoSpaceShip[index].spaceshipName);
        Debug.Log(infoSpaceShip[index].heat);

        // Llamar a la funcion Naves para que al pinchar START ya se seleccionen
        
        //Naves();
        

    }


    void Update()
    {
        labelNameShip.text = infoSpaceShip[index].spaceshipName;


        for(int i=0; i< modelosNaves.Length;i++)
        {
            if(i == index)
            {
                modelosNaves[i].SetActive(true);
            }
            else
            {
                modelosNaves[i].SetActive(false);
            }
        }

        for (int i = 0; i < caracteristicasNaves.Length; i++)
        {
            if (i == index)
            {
                caracteristicasNaves[i].SetActive(true);
            }
            else
            {
                caracteristicasNaves[i].SetActive(false);
            }
        }

        
        /****i =nave que el c?digo "mira"
           *index = indica la nave selecionda*/


        /*speedSlider.value = infoSpaceShip[index].speed;
        shieldSlider.value = infoSpaceShip[index].shield;
        heatSlider.value = infoSpaceShip[index].heat;*/  //Esto hace que cada vez que cambie la nave se coloquen los valores directamente


        // mientras el valor del Slider sea menor que el valor de la nave, el valor del Slider crece PREGUNTAR
        if (shieldSlider.value < infoSpaceShip[index].shield)
        {
            shieldSlider.value += Time.deltaTime * speed;
        }

        if ( speedSlider.value < infoSpaceShip[index].speed)
        {
            speedSlider.value += Time.deltaTime * speed;
        }

        if (heatSlider.value < infoSpaceShip[index].heat)
        {
            heatSlider.value += Time.deltaTime * speed;

        }


    }


   public void NextSpaceShip()
    {
        index++;
        if (index > 2)
        {
            index = 0;
        }

        // esto es para que cada nave empiece desde el principio, el Slider solo sube, no baja
        shieldSlider.value = 0;
        speedSlider.value = 0;
        heatSlider.value = 0;


        
        GameDataPersistent.instance.selectedSpaceship = infoSpaceShip[index];
    }

    public void PreviusSpaceShip()
    {
        index--;
        if (index < 0)
        {
            index = 2;
        }

        shieldSlider.value = 0;
        speedSlider.value = 0;
        heatSlider.value = 0;

       GameDataPersistent.instance.selectedSpaceship = infoSpaceShip[index];

    }

    public void CambiarEscena(int indice)
    {
        SceneManager.LoadScene(indice);
       
    }


    /* public void Naves()
     {

         if (index == 0)
         {
             nave1.SetActive(true);
             nave2.SetActive(false);
             nave3.SetActive(false);
         }
         if (index == 1)
         {
             nave2.SetActive(true);
             nave1.SetActive(false);
             nave3.SetActive(false);
         }
         if (index == 2)
         {
             nave3.SetActive(true);
             nave1.SetActive(false);
             nave2.SetActive(false);
         }
     }*/


}