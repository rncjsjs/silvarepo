using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Autobuilder : MonoBehaviour {

	public static void BuildGame () {

        var scenes = new string[] { "Assets/Scene/3D shooting.unity" };
        var flags = BuildOptions.Development;
        Debug.Log("start");
        BuildPipeline.BuildPlayer(scenes, "test.apk", BuildTarget.Android, flags);
        Debug.Log("end");

    }

}
