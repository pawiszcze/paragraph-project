using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_Selekta : MonoBehaviour {

    public int buttonNumber;
    Text tekstOpcji;
    int numer_slajdu = 0;


    void Start()
    {
        tekstOpcji = gameObject.GetComponent<Text>();
        tekstOpcji.text = Paragraph_Table.paragrafy[0, 0];
    }

    void Update()
    {

    }
}
