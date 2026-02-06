  using UnityEngine;
using UnityEngine.SceneManagement;

public class InfinityMode : MonoBehaviour
{
    
    public void StartNormalMode()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }
}
