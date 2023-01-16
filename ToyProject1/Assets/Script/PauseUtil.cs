using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseUtil : MonoBehaviour
{
    public GameObject Pause;

    private bool paused = false;



    void Start()
    {
        Pause.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Pause"))
        {
            paused = !paused;
        }
        if(paused)
        {
            Pause.SetActive(true);
            Time.timeScale = 0;
        }
        if (!paused)
        {
            Pause.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
