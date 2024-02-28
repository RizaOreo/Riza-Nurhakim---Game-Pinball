using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;
    public Button creditButton;

    private void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        exitButton.onClick.AddListener(ExitGame);
        creditButton.onClick.AddListener(ToCredit);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("Main Scene");
    }

    public void ToCredit()
    {
        SceneManager.LoadScene("Credit");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
