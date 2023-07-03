#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(FairyLine))]
public class FairyLineEditor : Editor
{

    public override void OnInspectorGUI()
    {

        base.OnInspectorGUI();
        var line = (FairyLine)target;

        if (GUILayout.Button("Setting"))
        {

            line.SettingArray();

        }

    }

}
#endif