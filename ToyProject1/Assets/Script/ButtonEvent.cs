using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonEvent : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("Example1_1");
    }
    public void EndButton()
    {
            Application.Quit();
    }
}
