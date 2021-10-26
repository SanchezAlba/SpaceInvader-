using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransicionesScript : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LoadNextLevel();
        }
    }

    public void LoadNextLevel()
    {
        StartCoroutine(loadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }
    IEnumerator loadLevel(int LevelIndex)
    {
        //play aniation
        transition.SetTrigger("start");

        //wait
        yield return new WaitForSeconds(transitionTime);

        //Scene manager
        SceneManager.LoadScene(LevelIndex);

    }
    

    

}
