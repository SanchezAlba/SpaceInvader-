using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpaceShipScreen : MonoBehaviour
{
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
        speedSlider.value = infoSpaceShip.speed;
        shieldSlider.value = infoSpaceShip.shield;
        heatSlider.value = infoSpaceShip.heat;

        

    }
}