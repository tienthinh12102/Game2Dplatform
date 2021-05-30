using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControler : MonoBehaviour
{
    public void _PlayButton()
    {
        SceneManager.LoadScene("Man1");
    }
    public void _LoadButton()
    {
        SceneManager.LoadScene("Man4");
    }
    public void _EndButton()
    {
        SceneManager.LoadScene("GameMenu");
    }
    public void _QuitButton()
    {
        Application.Quit();
    }
}
