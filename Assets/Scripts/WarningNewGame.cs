using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarningNewGame : MonoBehaviour
{
    public void OnClick()
    {
        Paragraph_Table.slideNumba = 0;
        Paragraph_Table.amuletCollected = 0;
        Foreground.foreground.gameObject.SetActive(false);
        Paragraph_Table.isGameBeingGamed = true;
    }
}