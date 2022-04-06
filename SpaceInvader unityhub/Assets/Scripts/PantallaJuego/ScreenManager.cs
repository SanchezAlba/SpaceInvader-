using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenManager : MonoBehaviour
{
    public GameObject pantallaPerdiste;

    public static ScreenManager instance;

    // Start is called before the first frame update
    void Start()
    {
        pantallaPerdiste.SetActive(false);

        if (ScreenManager.instance == null)
        {
            ScreenManager.instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        else
        {
            Destroy(this.gameObject);
        }

    }

   public void PantallaPerdiste()
    {
        pantallaPerdiste.SetActive(true);
    }

}
