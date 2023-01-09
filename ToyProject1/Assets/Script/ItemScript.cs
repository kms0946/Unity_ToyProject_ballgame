using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    public float rotateSpeed;
    AudioSource audio;

    void Awake()
    {
        audio = GetComponent<AudioSource>();
    }
    void Update()
    {
        transform.Rotate(Vector3.up*rotateSpeed*Time.deltaTime);
    }
}
 