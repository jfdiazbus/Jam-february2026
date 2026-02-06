using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{


    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    public void QUIT () 
    { 
        Debug.Log("QUIT");
        Application.Quit();
    }

}
