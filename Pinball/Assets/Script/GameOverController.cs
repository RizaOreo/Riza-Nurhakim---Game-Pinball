using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverController : MonoBehaviour
{
    public Button mainMenuButton;

    private void Start()
    {
        mainMenuButton.onClick.AddListener(MainMenu);
    }

    public void MainMenu()
    {   
        SceneManager.LoadScene("Main Menu");
    }
}
