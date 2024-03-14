using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif
public class MapEditor
{
#if UNITY_EDITOR

    // %(Ctrl), #(Shift), &(Alt)
    [MenuItem("Tools/GenerateMap %#g")]
    private static void GenerateMap()
    {
        // if (EditorUtility.DisplayDialog("Hello World", "Create?", "Create", "Cancel"))
        // {
        //     new GameObject("Hello World");
        // }
        GameObject go = GameObject.Find("Map");
        if (go == null) return;
        
        Util.FindChild<Tilemap>(go)

    }
#endif
}
