using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    // Specify the name of the scene to be loaded
    public string levelName;

    // Method to be called when the button is clicked
    public void LoadLevel()
    {
        // Load the specified level using the SceneManager
        SceneManager.LoadScene(levelName);
    }
}
