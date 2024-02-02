using UnityEngine.SceneManagement;
using UnityEngine;

public class Restart : MonoBehaviour
{
    public void RestartTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
