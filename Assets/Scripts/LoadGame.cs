using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class LoadGame : MonoBehaviour {

    public static LoadGame loadbutton;

	void Awake () {
        loadbutton = this;
        if (!File.Exists("C:/Data/Paragrafa/savefile.txt"))
        {
            loadbutton.gameObject.GetComponent<Button>().interactable = false;
        }
    }

    public void OnClick()
    {
            string loadfile = System.IO.File.ReadAllText("C:/Data/Paragrafa/savefile.txt");
            int toIndex = loadfile.IndexOf("|");
            string lastSlide = loadfile.Substring(0, toIndex);
            string amuCheck = loadfile.Substring(toIndex+2, 1);
            Paragraph_Table.slideNumba = int.Parse(lastSlide);
            Paragraph_Table.amuletCollected = int.Parse(amuCheck);
            Foreground.foreground.gameObject.SetActive(false);
            Paragraph_Table.isGameBeingGamed = true;
    }
}