using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeScript : MonoBehaviour {

    public void OnClick() {
        PauseScript.pauseMenu.gameObject.SetActive(false);
        Paragraph_Table.isGameBeingGamed = true;
    }
}
