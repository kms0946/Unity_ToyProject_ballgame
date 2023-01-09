using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManagement : MonoBehaviour
{
    public int TotalItemCount;
    public int StageNumber;
    public TextMeshProUGUI StageCountText;
    public TextMeshProUGUI PlayerCountText;

    void Awake()
    {
        StageCountText.text = "/ " + TotalItemCount;
    }
    public void GetItem(int count)
    {
        PlayerCountText.text = count.ToString();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(StageNumber);
        }
    }
}
