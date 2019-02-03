﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeToMenu : MonoBehaviour {

    public bool inMenu;
    public bool isActive = true;

    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape) && this.isActive)
        {
            if (!inMenu)
                SceneManager.LoadScene("menu");
            else
                SceneManager.LoadScene("SuperLabirynth");
        }
	}
}
