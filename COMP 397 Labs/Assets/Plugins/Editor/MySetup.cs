using UnityEngine;
using UnityEditor;
using System;
using System.Security.Policy;
using System.IO;

public static class MySetup
{
        [MenuItem("Setup/Create Folders")]
    public static void CreateMyFolders()
    {
        Folder.CreateFolders("_Project", "Animation", "Art", "Audio", "Fonts", "Matertials", "Prefabs", "ScriptableObjects", "Scripts", "Settings");

        AssetDatabase.Refresh();
    }
    static class Folder
{
    public static void CreateFolders(string root, params string[] folders)
    {
            var fullPath = Path.Combine(Application.dataPath, root);

            foreach (string folder in folders)
            {
                var folderPath = Path.Combine(fullPath, folder);
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
            }
    }
}

}

