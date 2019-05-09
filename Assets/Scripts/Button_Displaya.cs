using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button_Displaya : MonoBehaviour
{
    public int buttonNumber;
    int numer_slajdu;

    void Update()
    {
        numer_slajdu = Paragraph_Table.slideNumba;
        if (string.IsNullOrEmpty(Paragraph_Table.paragrafy[numer_slajdu, (buttonNumber * 2)]))
        {
            gameObject.GetComponent<Button>().interactable = false;
        }
        else
        {
            gameObject.GetComponent<Button>().interactable = true;
        };
    }
}
