using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TransicionesScript : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    public GameObject pantallaOpciones;

    // Update is called once per frame
   /* void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LoadNextLevel();
        }
    }*/

   /* public void LoadNextLevel()
    {
        StartCoroutine(loadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }*/


   /* IEnumerator loadLevel()
    {
        //play aniation
        transition.SetTrigger("start");

        //wait
        yield return new WaitForSeconds(transitionTime);

        //Scene manager

    }*/

    
    
    /*public void LoadPlayersCanvasFunc()
    {
        StartCoroutine(LoadPlayersCanvas());
    }

    public void LoadRecordsCanvasFunc()

    {
        StartCoroutine(LoadRecordsCanvas());
    }

    public void LoadOPtionsCanvasFunc()
    {
        StartCoroutine(LoadOptionsCanvas());
    }

    IEnumerator LoadPlayerCanvas()
    {
        transition.SetTrigger("start");
        yield return new WaitForSeconds(transitionTime);
        GameController.instance.PlayersSelectSetActive(true);
        GameController.instance.InitialScreenSetActive(false);
    } */
    
}
