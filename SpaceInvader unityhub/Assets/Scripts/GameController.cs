using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject introScreen;
    public GameObject pantallaEspera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            Debug.Log("esto furula");
            EnablePanatallaEspera();
            DisableIntroScreen();
        }
    }

    void EnablePanatallaEspera()
    {
        pantallaEspera.SetActive(true);
    }
    void DisableIntroScreen()
    {
        introScreen.SetActive(false);
    }

}
