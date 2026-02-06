  using UnityEngine;
using UnityEngine.SceneManagement;

public class NWLG : MonoBehaviour
{

    public void StartNewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    } 

}