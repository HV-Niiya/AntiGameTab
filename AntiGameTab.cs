using UnityEditor;

[InitializeOnLoad]
public static class AntiGameTab
{
    static AntiGameTab()
    {
        EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
    }

    private static void OnPlayModeStateChanged(PlayModeStateChange state)
    {
        if (state == PlayModeStateChange.EnteredPlayMode)
        {
            EditorApplication.ExecuteMenuItem("Window/General/Scene");
        }
    }
}
