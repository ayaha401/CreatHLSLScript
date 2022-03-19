//====================================================================================================
// v1.0.1
// Twitter : @ayaha__401
//====================================================================================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class CreatHLSLScript : EditorWindow
{
    static string path;

    [MenuItem("Assets/Create/Shader/HLSLScript")]
    private static void OpenWindow()
    {
        foreach (Object obj in Selection.GetFiltered(typeof(DefaultAsset), SelectionMode.DeepAssets))
        {
            if (obj is DefaultAsset)
            {
                path = AssetDatabase.GetAssetPath(obj);
            }
        }

        path = EditorUtility.SaveFilePanelInProject("CreatHLSLScript", "NewShader", "hlsl", "", path);
        if (!string.IsNullOrEmpty(path))
        {
            path = AssetDatabase.GenerateUniqueAssetPath(path);
            File.WriteAllText(path,"");
            AssetDatabase.Refresh();
        }
    }
}
