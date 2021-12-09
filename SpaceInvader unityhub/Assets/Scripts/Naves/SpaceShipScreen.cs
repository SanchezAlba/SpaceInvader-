using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpaceShipScreen : MonoBehaviour
{
    public TextMeshProUGUI labelNameShip;

    public SpashipData infoSpaceShip;
    


    public Slider speedSlider;
    public Slider shieldSlider;
    public Slider heatSlider;

    private float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(infoSpaceShip.speed);
        Debug.Log(infoSpaceShip.shield);
        Debug.Log(infoSpaceShip.spaceshipName);
        Debug.Log(infoSpaceShip.heat);
    }


   void Update()
    {
        labelNameShip.text = infoSpaceShip.spaceshipName;


        speedSlider.value = infoSpaceShip.speed;
        shieldSlider.value = infoSpaceShip.shield;
        heatSlider.value = infoSpaceShip.heat;

        
        if (shieldSlider.value < infoSpaceShip.shield)
        {
            shieldSlider.value += Time.deltaTime * speed;
        }

        if ( speedSlider.value < infoSpaceShip.speed)
        {
            shieldSlider.value += Time.deltaTime * speed;
        }

        if (heatSlider.value < infoSpaceShip.heat)
        {
            shieldSlider.value += Time.deltaTime * speed;
        }

    }
}