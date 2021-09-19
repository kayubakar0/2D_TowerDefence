using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void play()
    {
        Application.LoadLevel("Gameplay");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void backtomenu()
    {
        Application.LoadLevel("Main menu");
    }
}
