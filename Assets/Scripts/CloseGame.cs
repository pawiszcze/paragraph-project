using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseGame : MonoBehaviour {

    public static CloseGame exitbutton;

    public void OnClick()
    {
        Application.Quit();
    }
}