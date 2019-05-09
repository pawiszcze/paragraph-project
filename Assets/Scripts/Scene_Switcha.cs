using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Scene_Switcha : MonoBehaviour {

    public int buttonNumber;
    string destination;
    int numer_slajdu;
    string saveString;

    void Start () {
        numer_slajdu = Paragraph_Table.slideNumba;
    }
	
	public void Whateva (bool end) {
        numer_slajdu = Paragraph_Table.slideNumba;
        destination = Paragraph_Table.paragrafy[numer_slajdu, buttonNumber * 2];
        int i = 0;
        while (i < 50) {
            if (Paragraph_Table.paragrafy[i, 0] == destination)
            {
                Paragraph_Table.slideNumba = i;

                if (!end)
                {
                    if (Paragraph_Table.slideNumba == 3)
                    {
                        Paragraph_Table.amuletCollected = 1;
                    }

                    if (!Directory.Exists("C:/Data/Paragrafa"))
                    {
                        Directory.CreateDirectory("C:/Data/Paragrafa");
                    }
                    saveString = string.Concat(Paragraph_Table.slideNumba.ToString(), "||", Paragraph_Table.amuletCollected.ToString());
                    System.IO.File.WriteAllText("C:/Data/Paragrafa/savefile.txt", saveString);
                    break;
                } else
                {
                    File.Delete("C:/Data/Paragrafa/savefile.txt");
                    break;
                }
            } else
            {
                i++;
            }
        }
    }

    public void Next()
    {
        if (Paragraph_Table.paragrafy[Paragraph_Table.slideNumba, 10] == "Y")
        {
            Paragraph_Table.slideNumba = Paragraph_Table.slideNumba + 1;
            Debug.Log("1");
            saveString = string.Concat(Paragraph_Table.slideNumba.ToString(), "||", Paragraph_Table.amuletCollected.ToString());
            System.IO.File.WriteAllText("C:/Data/Paragrafa/savefile.txt", saveString);
        } else if (Paragraph_Table.paragrafy[Paragraph_Table.slideNumba, 10].Equals("CheckForAmulet")){
            Debug.Log("2");
            if (Paragraph_Table.amuletCollected == 1)
            {
                Paragraph_Table.slideNumba = 23;                                                         //Attension
            }
            else
            {
                Paragraph_Table.slideNumba = 41;                                                         //Attension
            }
            saveString = string.Concat(Paragraph_Table.slideNumba.ToString(), "||", Paragraph_Table.amuletCollected.ToString());
            System.IO.File.WriteAllText("C:/Data/Paragrafa/savefile.txt", saveString);
        } else if(Paragraph_Table.paragrafy[Paragraph_Table.slideNumba, 10].Equals("ENDoftheGAME0"))
        {
            Debug.Log("3");
            Whateva(true);
            
        } else
        {
            Debug.Log(Paragraph_Table.paragrafy[Paragraph_Table.slideNumba, 0]);
            Whateva(false);
        }
        
        
    }
}
