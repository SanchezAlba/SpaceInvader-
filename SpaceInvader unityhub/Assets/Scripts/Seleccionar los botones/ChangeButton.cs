using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeButton : MonoBehaviour
{
    public GameObject currentScreen;
    public GameObject nextScreen;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void ChangeScreen()
    {
        currentScreen.SetActive(false);
        nextScreen.SetActive(true);
    }

  
}
