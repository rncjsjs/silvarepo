﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main : MonoBehaviour {

    static public int Score = 0;
    static public int Lives = 3;
    public int FinishScore = 1000;

	// Update is called once per frame
	void Update () {
		
        if(Score >= FinishScore)
        {
            Score = 0;
            SceneManager.LoadScene("Win");
        }

	}

    void OnGUI()
    {
    
        GUI.Label(new Rect(10.0f,10.0f, 200.0f, 20.0f),Main.Score.ToString());
        GUI.Label(new Rect(10.0f, 30.0f, 200.0f, 20.0f), Main.Lives.ToString());
        
    }
}
