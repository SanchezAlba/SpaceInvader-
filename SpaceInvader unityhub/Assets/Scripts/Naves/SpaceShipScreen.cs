using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpaceShipScreen : MonoBehaviour
{
    public TextMeshProUGUI labelNameShip;

    public SpashipData[] infoSpaceShip;
    public GameObject[] modelosNaves;
    public GameObject[] caracteristicasNaves;
    
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

    }


    void Update()
    {
        labelNameShip.text = infoSpaceShip[index].spaceshipName;

        // mientras que i(nave que mira el codigo) sea menor que la cantidad de modelos naves, va a seguir
        // aumentado el array. Cuando la nave es igual al araay[i] se activa, si es diferente, se desactiva
       
        
        // PAra esto hacer funciones y ponerlas en los botones, luego las llamamos en el update.
        //evitar que el uodate ocupe toda la pantalla
        
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


        // mientras el valor del Slider sea menor que el valor de la nave, el valor del Slider crece 
        if (shieldSlider.value < infoSpaceShip[index].shield)
        {
            shieldSlider.value += Time.deltaTime * speed;
        }
        else if(shieldSlider.value > infoSpaceShip[index].shield) // esto es para que el slider baje. en la otra era que si 0 < 2 el slider sube, en esta, si 2>0 el slider baja
        {
            shieldSlider.value -= Time.deltaTime * speed;
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
        // esto es para que cada nave empiece desde el principio, el Slider solo sube, no baja
        index++;
        if (index > 2)
         {
            index = 0;
         }

        //shieldSlider.value = 0;
        speedSlider.value = 0;
        heatSlider.value = 0;

    }

    public void PreviusSpaceShip()
    {
        index--;
        if (index < 0)
         {
            index = 2;
         }

//        shieldSlider.value = 0;
        speedSlider.value = 0;
        heatSlider.value = 0;

    }

}