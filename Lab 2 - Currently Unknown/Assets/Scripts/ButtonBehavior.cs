using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehavior : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
