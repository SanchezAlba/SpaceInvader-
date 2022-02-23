using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDataPersistent : MonoBehaviour
{
    public SpashipData selectedSpaceship;
    public static GameDataPersistent instance;

    private void Awake()
    {
        if (GameDataPersistent.instance == null)
        {
            GameDataPersistent.instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
}
