using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpaceShipScreen : MonoBehaviour
{
    public TextMeshProUGUI labelNameShip;

    public SpashipData[] infoSpaceShip;
    
    public GameObject nave1;
    public GameObject nave2;
    public GameObject nave3;

    public int index = 0;

    public Slider speedSlider;
    public Slider shieldSlider;
    public Slider heatSlider;

    private float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(infoSpaceShip[index].speed);
        Debug.Log(infoSpaceShip[index].shield);
        Debug.Log(infoSpaceShip[index].spaceshipName);
        Debug.Log(infoSpaceShip[index].heat);

        // Llamar a la funcion Naves para que al pinchar START ya se seleccionen
        Naves();

        /*
         * otra forma naves:  
         * 
         * public GameObject modelos naves;
         * START
         for (int =o; i < modelos naves.<length, i++)
        {
            if ( i==index)
            {

                modelos NAves[i].SetActive(true);
            }

        else
        {
            modelos NAves[i].SetActive(false);
        }
        }

        ***i =nave que el código "mira"
        *index = indica la nave selecionda
         */

    }


    void Update()
    {
        labelNameShip.text = infoSpaceShip[index].spaceshipName;


        /*speedSlider.value = infoSpaceShip[index].speed;
        shieldSlider.value = infoSpaceShip[index].shield;
        heatSlider.value = infoSpaceShip[index].heat;*/  //Esto hace que cada vez que cambie la nave se coloquen los valores directamente

        
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

            shieldSlider.value = 0;
            speedSlider.value = 0;
            heatSlider.value = 0;

        }

         // esto e spara que cada nave empiece desde el principio, el Slider solo sube, no baja
        
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

    }




    public void Naves()
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
    }

  

}