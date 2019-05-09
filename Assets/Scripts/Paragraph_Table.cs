using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paragraph_Table : MonoBehaviour {

    public static Paragraph_Table paragraph_Table;
    public static int slideNumba;
    public static string[,] paragrafy = new string[100,11];
    public static bool isGameBeingGamed;
    public static int amuletCollected;

    void Awake () {
        paragraph_Table = this;
        isGameBeingGamed = false;
        amuletCollected = 0;

        paragrafy[0,0] = "Pro_WakeUp_1back";
        paragrafy[0,10] = "Y";

        paragrafy[1, 0] = "Pro_WakeUp_2back";
        paragrafy[1,2] = "Pro_Recon1a_vol1_back";
        paragrafy[1,4] = "Pro_Argue1back";
        paragrafy[1,6] = "Pro_Recon_back";

        paragrafy[2, 0] = "Pro_Recon_back";
        paragrafy[2,2] = "Pro_Recon1a_vol1_back";
        paragrafy[2,4] = "Pro_Argue1back";

        paragrafy[3, 0] = "Pro_Recon1a_vol1_back";
        paragrafy[3, 10] = "Y";

        paragrafy[4, 0] = "Pro_Recon2aback";
        paragrafy[4, 2] = "Pro_PubDrink1back";

        paragrafy[5, 0] = "Pro_Argue1back";
        paragrafy[5, 10] = "Y";

        paragrafy[6, 0] = "Pro_Argue2back";
        paragrafy[6, 6] = "Pro_Drink1back";
        paragrafy[6, 8] = "Pro_Drink1back";

        paragrafy[7, 0] = "Pro_PubDrink1back";
        paragrafy[7, 10] = "Y";

        paragrafy[8, 0] = "Pro_PubDrink2back";
        paragrafy[8, 10] = "Y";

        paragrafy[9, 0] = "Pro_PubDrink3back";
        paragrafy[9, 6] = "Pro_Dorf_back";
        paragrafy[9, 8] = "Pro_ExitDrink";

        paragrafy[10, 0] = "Pro_Drink1back";
        paragrafy[10, 10] = "Y";

        paragrafy[11, 0] = "Pro_Drink2back";
        paragrafy[11, 6] = "Pro_Dorf_back";
        paragrafy[11, 8] = "Pro_ExitDrink";

        paragrafy[12, 0] = "Pro_Dorf_back";
        paragrafy[12, 6] = "Pro_AskDorf1_back";
        paragrafy[12, 8] = "Pro_AngeryGurl1_back";

        paragrafy[13, 0] = "Pro_AskDorf1_back";
        paragrafy[13, 10] = "Y";

        paragrafy[14, 0] = "Pro_AskDorf2_back";
        paragrafy[14, 10] = "TombRaider_Gates";

        paragrafy[15, 0] = "Pro_AngeryGurl1_back";
        paragrafy[15, 10] = "Y";

        paragrafy[16, 0] = "Pro_AngeryGurl2_back";
        paragrafy[16, 10] = "TombRaider_Gates";

        paragrafy[17, 0] = "Pro_ExitDrink";
        paragrafy[17, 6] = "Pro_EscapePunch1_back";
        paragrafy[17, 8] = "Pro_EscapePunch1_back";

        paragrafy[18, 0] = "Pro_EscapePunch1_back";
        paragrafy[18, 10] = "Y";

        paragrafy[19, 0] = "Pro_EscapePunch2_back";
        paragrafy[19, 10] = "Y";

        paragrafy[20, 0] = "Pro_EscapePunch3_back";
        paragrafy[20, 10] = "TombRaider_Gates";

        paragrafy[21, 0] = "TombRaider_Gates";
        paragrafy[21, 10] = "Y";

        paragrafy[22, 0] = "TombRaider_Enter";
        paragrafy[22, 10] = "CheckForAmulet";

        paragrafy[23, 0] = "TombRaider_IsArtifact";
        paragrafy[23, 10] = "Y";

        paragrafy[24, 0] = "TombRider_GoodFite";
        paragrafy[24, 10] = "Y";

        paragrafy[25, 0] = "TombRider_TombISArtifact";
        paragrafy[25, 2] = "TombRaider_Escape";
        paragrafy[25, 4] = "TombRaider_PressOn1";

        paragrafy[26, 0] = "TombRaider_GoodEnd";
        paragrafy[26, 10] = "ENDoftheGAME0";

        paragrafy[27, 0] = "ENDoftheGAME0";                                                        //Attension (Game end - return to menu, delete savefile)

        paragrafy[28, 0] = "TombRaider_PressOn1";
        paragrafy[28, 10] = "Y";

        paragrafy[29, 0] = "TombRaider_PressOn2";
        paragrafy[29, 2] = "TombRaider_2ndFite_WITHAmulet";
        paragrafy[29, 4] = "TombRaider_GoodEnd";

        paragrafy[30, 0] = "TombRaider_2ndFite_WITHAmulet";
        paragrafy[30, 2] = "TombRaider_L8Escape";
        paragrafy[30, 4] = "TombRaider_Altar";

        paragrafy[31, 0] = "TombRaider_L8Escape";
        paragrafy[31, 10] = "TombRaider_GoodEnd";

        paragrafy[32, 0] = "TombRaider_Altar";
        paragrafy[32, 2] = "TombRaider_Interrupt";
        paragrafy[32, 4] = "TombRaider_Wait1";

        paragrafy[33, 0] = "TombRaider_Wait1";
        paragrafy[33, 10] = "Y";

        paragrafy[34, 0] = "TombRaider_Wait2";
        paragrafy[34, 10] = "Y";

        paragrafy[35, 0] = "TombRaider_Wait3";
        paragrafy[35, 10] = "ENDoftheGAME0";

        paragrafy[36, 0] = "TombRaider_Interrupt";
        paragrafy[36, 2] = "TombRaider_GoodEnd";
        paragrafy[36, 4] = "TombRaider_Phil";

        paragrafy[37, 0] = "TombRaider_Phil";
        paragrafy[37, 10] = "Y";

        paragrafy[38, 0] = "TombRaider_WorstEnd1";
        paragrafy[38, 10] = "Y";

        paragrafy[39, 0] = "TombRaider_WorstEnd2";
        paragrafy[39, 10] = "Y";

        paragrafy[40, 0] = "TombRaider_WorstEnd3";
        paragrafy[40, 10] = "ENDoftheGAME0";

        paragrafy[41, 0] = "TombRaider_NOArtifact";
        paragrafy[41, 10] = "Y";

        paragrafy[42, 0] = "TombRider_BadFite";
        paragrafy[42, 10] = "Y";

        paragrafy[43, 0] = "TombRider_BFiteEnd";
        paragrafy[43, 10] = "Y";

        paragrafy[44, 0] = "TombRider_TombNOA";
        paragrafy[44, 2] = "TombRaider_Escape";
        paragrafy[44, 4] = "TombRaider_NPressOn1";

        paragrafy[45, 0] = "TombRaider_Escape";
        paragrafy[45, 10] = "TombRaider_GoodEnd";

        paragrafy[46, 0] = "TombRaider_NPressOn1";
        paragrafy[46, 10] = "Y";

        paragrafy[47, 0] = "TombRaider_NPressOn2";
        paragrafy[47, 4] = "TombRaider_GoodEnd";
        paragrafy[47, 2] = "TombRaider_2ndFite_NOAmulet1";

        paragrafy[48, 0] = "TombRaider_2ndFite_NOAmulet1";
        paragrafy[48, 10] = "Y";

        paragrafy[49, 0] = "TombRaider_2ndFite_NOAmulet2";
        paragrafy[49, 2] = "TombRaider_L8Escape";
        paragrafy[49, 4] = "TombRaider_Altar";
    }

    private void Pause()
    {
        if (isGameBeingGamed)
        {
            PauseScript.pauseMenu.gameObject.SetActive(true);
            isGameBeingGamed = false;
        }
        else
        {
            PauseScript.pauseMenu.gameObject.SetActive(false);
            isGameBeingGamed = true;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            Pause();
        }
    }
}
