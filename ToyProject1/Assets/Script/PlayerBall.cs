using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBall : MonoBehaviour
{
    public float jumpPower;
    public int itemCount;
    public GameManagement manager;
    bool jumpJudge;
    Rigidbody rid;

    void Awake()
    {
        jumpJudge = false;
        rid = GetComponent<Rigidbody>();

    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && !jumpJudge)
        {
            jumpJudge = true;
            rid.AddForce(new Vector3(0,jumpPower,0), ForceMode.Impulse);
        }
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(h, 0, v);//질량을 조절하거나 속도를 조절하는 형태 구현
        rid.AddForce(vec,ForceMode.Impulse);

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            jumpJudge = false;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item")
        {
            itemCount++;
            manager.GetItem(itemCount);
            GetComponent<AudioSource>().Play();
            other.gameObject.SetActive(false);
        }
        else if (other.tag == "Finish")
        {
            if (itemCount == manager.TotalItemCount)
            {
                SceneManager.LoadScene(manager.StageNumber+1);
            }
            else
            {
                SceneManager.LoadScene(manager.StageNumber);
            }
        }
    }
}
