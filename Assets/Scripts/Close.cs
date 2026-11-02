using UnityEngine;

public class Close : MonoBehaviour
{
    [Header("Configuració")]
    [SerializeField] private KeyCode closeKey = KeyCode.Escape;

    void Update()
    {

        if (Input.GetKeyDown(closeKey))
        {
            CloseApp();
        }
    }

    public void CloseApp()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else
            Application.Quit();
        #endif
    }
}
