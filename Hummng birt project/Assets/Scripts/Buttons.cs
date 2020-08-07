using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    public void PlayPenguin()
    {
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        if (Application.platform == RuntimePlatform.WebGLPlayer)
        {
            Application.OpenURL("about:blank");
        }
    }

    public void PlayHummingBird()
    {
        SceneManager.LoadScene(1);
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void MLAgents()
    {
        SceneManager.LoadScene(5);
    }

    public void Pelindrom()
    {
        SceneManager.LoadScene(3);
    }

    public void ComputationalModel()
    {
        SceneManager.LoadScene(6);
    }

    public void RollABall()
    {
        SceneManager.LoadScene(4);
    }

    public void Parenthesis()
    {
        SceneManager.LoadScene(7);
    }

    public void ItemsLearned()
    {
        SceneManager.LoadScene(8);
    }

    public void InstructorWeb()
    {
        Application.OpenURL("http://www.niazilab.com/");
    }

    public void PelindromeChossen()
    {
        SceneManager.LoadScene(9);
    }
}
