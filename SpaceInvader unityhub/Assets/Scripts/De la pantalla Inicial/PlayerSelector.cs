using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSelector : MonoBehaviour
{
    public Image[] selectionBoxes;


    // Start is called before the first frame update
    void Start()
    {
        foreach (var img in this.selectionBoxes);
    }

    public void select(int index)
    {
        foreach (var img in this.selectionBoxes)
        {
            img.gameObject.SetActive(false);
        }
        this.selectionBoxes[index].gameObject.SetActive(true);

    }
}
