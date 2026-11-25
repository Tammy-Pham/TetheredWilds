using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public void start()
    {
        SceneManager.LoadScene(1);
    }
}
