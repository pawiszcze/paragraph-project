using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScript : MonoBehaviour {

    public static SplashScript warningSplash;

	void Awake () {
        warningSplash = this;
        this.gameObject.SetActive(false);
	}
}