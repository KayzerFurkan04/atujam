using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menubuttonscode : MonoBehaviour
{
    public string discordurl;

    public void playbutton()
    {
        SceneManager.LoadScene(4);
    }

    public void settingsbutton()
    {
        SceneManager.LoadScene(2);
    }

    public void creditsbutton()
    {
        SceneManager.LoadScene(3);
    }

    public void quitbutton()
    {
        Application.Quit();
    }

    public void discord()
    {
        Application.OpenURL(discordurl);
    }


    public void settingsgeri()
    {
        SceneManager.LoadScene(1);
    }

    public void easy()
    {
        SceneManager.LoadScene(0);
    }

    public void medium()
    {
        SceneManager.LoadScene(0);
    }

    public void hard()
    {
        SceneManager.LoadScene(0);
    }
}
