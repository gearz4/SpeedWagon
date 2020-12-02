using UnityEngine;
using UnityEngine.SceneManagement;

public class Backtomenu : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }

    public void Warp2()
    {
        SceneManager.LoadScene("Main");
    }
}