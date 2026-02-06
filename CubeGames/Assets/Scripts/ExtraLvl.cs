  using UnityEngine;
using UnityEngine.SceneManagement;

public class ExtraLvl : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quitgame()
    {
        Debug.Log("Quitteng game..."); 
        Application.Quit();
    }

} 
