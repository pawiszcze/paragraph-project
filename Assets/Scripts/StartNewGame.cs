using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class StartNewGame : MonoBehaviour {

    public static StartNewGame newgamebutton;

	void Awake () {
        newgamebutton = this;
	}
	
    public void OnClick()
    {
        if (!File.Exists("C:/Data/Paragrafa/savefile.txt"))
        {
            Paragraph_Table.slideNumba = 0;
            Paragraph_Table.amuletCollected = 0;
            Foreground.foreground.gameObject.SetActive(false);
            Paragraph_Table.isGameBeingGamed = true;
        } else
        {
            SplashScript.warningSplash.gameObject.SetActive(true);
        }
        
    }
}