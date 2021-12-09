using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameObjectDataInfo : MonoBehaviour
{
    public TextMeshProUGUI labelNameShip;


    public SpashipData[] myShip;
    public Transform iconParents;
    public Transform iconShield;
    public Transform iconHeat;

    public int index = 0;

    // Update is called once per frame
    void Update()
    {


        labelNameShip.text = myShip[index].spaceshipName;


        for (int iconoModificado = 0;iconoModificado< iconParents.childCount; iconoModificado++)
        {
            if(myShip[index].speed > iconoModificado)
            {
                iconParents.GetChild(iconoModificado).gameObject.SetActive(true);
            }

            else
            {
                iconParents.GetChild(iconoModificado).gameObject.SetActive(false);
            }
        }


        for (int iconoModificado = 0; iconoModificado < iconParents.childCount; iconoModificado++)
        {
            if (myShip[index].shield > iconoModificado)
            {
                iconShield.GetChild(iconoModificado).gameObject.SetActive(true);
            }

            else
            {
                iconShield.GetChild(iconoModificado).gameObject.SetActive(false);
            }
        }







        for (int iconoModificado = 0; iconoModificado < iconParents.childCount; iconoModificado++)
        {
            if (myShip[index].heat > iconoModificado)
            {
                iconHeat.GetChild(iconoModificado).gameObject.SetActive(true);
            }

            else
            {
                iconHeat.GetChild(iconoModificado).gameObject.SetActive(false);
            }
        }

    }
}
