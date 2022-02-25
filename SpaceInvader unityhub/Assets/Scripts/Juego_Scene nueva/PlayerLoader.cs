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

      nave.transform.localPosition = new Vector3(-7, -2.5f, 89);
       nave.transform.localScale= new Vector3 (50,50,50);
       nave.transform.rotation = Quaternion.Euler(0,180,0);
        
       //nave.transform.parent = transform; // esto es por si lo queremos meter dentro de un  empty. Pues para que aparezca ahí
    }
}
