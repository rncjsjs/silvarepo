using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEditor;

public class Autobuilder : MonoBehaviour{

	public static void BuildGame () {

        var scenes = new string[] { "Assets/Scene/3D shooting.unity" };
        var flags = BuildOptions.Development;
        Debug.Log("s#t#a#r#t");
        BuildPipeline.BuildPlayer(scenes, "D:/젠킨스/workspace/Test-1/test.apk", BuildTarget.Android, flags);
        Debug.Log("e#n#d");

    }

}
