using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public void Warp()
    {
        SceneManager.LoadScene("gameplay");
    }

    public void Quit()
    {
        Application.Quit();
    }
}