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

    }


   void Update()
    {
        labelNameShip.text = infoSpaceShip[index].spaceshipName;


        speedSlider.value = infoSpaceShip[index].speed;
        shieldSlider.value = infoSpaceShip[index].shield;
        heatSlider.value = infoSpaceShip[index].heat;

        
        if (shieldSlider.value < infoSpaceShip[index].shield)
        {
            shieldSlider.value += Time.deltaTime * speed;
        }

        if ( speedSlider.value < infoSpaceShip[index].speed)
        {
            shieldSlider.value += Time.deltaTime * speed;
        }

        if (heatSlider.value < infoSpaceShip[index].heat)
        {
            shieldSlider.value += Time.deltaTime * speed;
        }

    }


    public void NextSpaceShip()
    {
        index++;
        if (index > 2)
        {
            index = 0;
        }
  
    }

    public void PreviusSpaceShip()
    {
        index--;
        if (index < 0)
        {
            index = 2;
        }
     
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