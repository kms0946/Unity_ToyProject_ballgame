using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonEvent : MonoBehaviour
{
    public GameManagement manager;

    public void StartButton()
    {
        SceneManager.LoadScene("StageSelect");
    }
    public void EndButton()
    {
            Application.Quit();
    }
    public void SelectButton()
    {
        SceneManager.LoadScene("Example1_1");
    }
    public void SelectButton2()
    {
        SceneManager.LoadScene("Example1_2");
    }
}
