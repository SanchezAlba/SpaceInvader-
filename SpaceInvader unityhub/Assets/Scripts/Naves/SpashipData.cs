using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Data", menuName = "SpaceShip", order = 1)]   //lo de "2" es el nombre que yo quiera

public class SpashipData : ScriptableObject
{

    
    public static SpashipData instance; // Instancia en 

    public string spaceshipName;
    [Range(0, 5.0f)]
    public int shield = 4;
    [Range(0, 5.0f)]
    public int speed= 2;
    [Range(0, 5.0f)]
    public int heat = 3;

    public GameObject prefab; //se usa cuando se carga la escena


    void start()
    { 
    
        if(SpashipData.instance ==null)
        {
            SpashipData.instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
}



