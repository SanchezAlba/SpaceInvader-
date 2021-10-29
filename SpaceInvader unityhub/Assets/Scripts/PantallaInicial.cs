using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PantallaInicial : MonoBehaviour
{
    public GameObject selectedOne;
    public GameObject selectedTwo;
    public GameObject selectedThree;

    public GameObject playButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateSelector()
    {
        if(playButton)
        {
            selectedOne.SetActive(true);
        }
    }
}
