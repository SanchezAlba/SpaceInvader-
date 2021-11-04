using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectedButton : MonoBehaviour
{
    public Button selectedButton;
   

  

    public void OnEnable()
    {
        selectedButton.Select();
      
    }
}
