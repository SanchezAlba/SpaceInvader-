using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoader : MonoBehaviour
{
    

    private void Awake()
    {
      GameObject nave = Instantiate(GameDataPersistent.instance.selectedSpaceship.prefab); //ponerlo public y meter al prefab 
                                                                                           // nave.transform.localPosition()  //para decir en que posicio lo queremos

        //nave.transform.localScale *= 1;
        //nave.transform = posicionNave;

      nave.transform.localPosition = new Vector3(-8, 2, 8);
      // nave.transform.position = new Vector3(-69, -40, 85);
       nave.transform.localScale= new Vector3 (100,100,100);
       nave.transform.rotation = Quaternion.Euler(0,0,0);
        
       //nave.transform.parent = transform; // esto es por si lo queremos meter dentro de un  empty. Pues para que aparezca ahí
    }
}
