using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoader : MonoBehaviour
{

    private void Awake()
    {
      GameObject nave = Instantiate(GameDataPersistent.instance.selectedSpaceship.prefab); //ponerlo public y meter al prefab
                                                                                           // nave.transform.localPosition()  //para decir en que posicio lo queremos

       //nave.transform.parent = transform; // esto es por si lo queremos meter dentro de un  empty. Pues para que aparezca ah�
    }
}
