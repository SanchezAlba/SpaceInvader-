using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public string ScenNavePrincipal;
   // public string scenNaveResert;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoMenuPrincipal()
    {
        SceneManager.LoadScene(ScenNavePrincipal);
    }

}
