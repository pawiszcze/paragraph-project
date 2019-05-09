using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour {

    public static PauseScript pauseMenu;

    private void Awake()
    {
        pauseMenu = this;
        this.gameObject.SetActive(false);
    }
}
