using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MyMenu
{

	[MenuItem("Build/AutoBuild")]
    private static void AutoBuild()
    {
        Autobuilder.BuildGame();
    }
}
