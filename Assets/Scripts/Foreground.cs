using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foreground : MonoBehaviour {

    public static Foreground foreground;

    void Awake()
    {
        foreground = this;
    }
}