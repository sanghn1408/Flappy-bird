using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeMovement : MonoBehaviour
{    
    void Start()
    {
        
    }
    void Update()
    {      
    }
    void FixedUpdate()
    {
        if (GameObject.FindObjectOfType<playerController>().score >=0 && GameObject.FindObjectOfType<playerController>().score <5)
        {
            transform.position = Vector2.Lerp(transform.position, new Vector2(transform.position.x-0.4f, transform.position.y), 0.1f);
        }
        if (GameObject.FindObjectOfType<playerController>().score>=5 && GameObject.FindObjectOfType<playerController>().score < 15)
        {
            transform.position = Vector2.Lerp(transform.position, new Vector2(transform.position.x-0.4f, transform.position.y), 0.15f);
        }
        if (GameObject.FindObjectOfType<playerController>().score >= 15)
        {
            transform.position = Vector2.Lerp(transform.position, new Vector2(transform.position.x-0.4f, transform.position.y), 0.2f);
        }
        if (GameObject.FindObjectOfType<playerController>().score >= 35)
        {
            transform.position = Vector2.Lerp(transform.position, new Vector2(transform.position.x - 0.4f, transform.position.y), 0.3f);
        }
    }
}

