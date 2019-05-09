using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Screen_Choice : MonoBehaviour {

    string tytul_slajdu;
    int numer_slajdu;

	void Update () {
        numer_slajdu = Paragraph_Table.slideNumba;
        tytul_slajdu = Paragraph_Table.paragrafy[numer_slajdu, 0];
        gameObject.GetComponent<RawImage>().texture = Resources.Load(tytul_slajdu) as Texture2D;
    }
}