using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
   public void Puzzle1()
    {
        SceneManager.LoadScene("Puzzle1");
    }

    public void Puzzle2()
    {
        SceneManager.LoadScene("Puzzle2");
    }

    public void TracingA()
    {
        SceneManager.LoadScene("TracingA");

    }
    public void TracingB()
    {
        SceneManager.LoadScene("TracingB");
    }

    public void Mainmenu()
    {
        SceneManager.LoadScene("Mainmenu");

    }

    public void PuzzleMainmenu()
    {
        SceneManager.LoadScene("Puzzle MainMenu");

    }

    public void Exit()
    {
        Application.Quit();
    }
}
