using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeScensManager : MonoBehaviour
{
    public void GoToPlayGround()
    {
        PlayerPrefs.DeleteKey("CoinCount");
        SceneManager.LoadScene("PlayGround");
    }
    public void ContinuePlay()
    {
        if (PlayerPrefs.HasKey("PrevScene"))
        {
            string prevSceneName = PlayerPrefs.GetString("PrevScene");
            SceneManager.LoadScene(prevSceneName);
        }
    }
    public void GoToHome()
    {

        SceneManager.LoadScene("Home");
    }
    public void GoTocredits()
    {

        SceneManager.LoadScene("credits");
    }

    public void GoTocredits3()
    {

        SceneManager.LoadScene("credits3");
    }

    public void ExitGame()
    {
        Application.Quit();


    }
}
