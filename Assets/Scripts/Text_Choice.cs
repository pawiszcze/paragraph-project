using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_Choice : MonoBehaviour {
    public int buttonNumber;
    Text tekstOpcji;
    int numer_slajdu;

    void Update()
    {
        numer_slajdu = Paragraph_Table.slideNumba;
        tekstOpcji = gameObject.GetComponent<Text>();
        tekstOpcji.text = Paragraph_Table.paragrafy[numer_slajdu, buttonNumber * 2];
    }

}
