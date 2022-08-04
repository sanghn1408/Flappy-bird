using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeGenerator : MonoBehaviour
{
    
    [SerializeField] GameObject pipes;
    int timer = 0;
    void Start()
    {
    }
    void FixedUpdate()
    {
        timer++;      
        if (GameObject.FindObjectOfType<playerController>().score >= 0 && GameObject.FindObjectOfType<playerController>().score < 5)
        {
            if (timer >= 100)
            {
                timer = 0;
                GameObject pipe = Instantiate(pipes, new Vector2(pipes.transform.position.x, pipes.transform.position.y + Random.Range(-2, 2)), pipes.transform.rotation);//-2 2
                Destroy(pipe, 3.5f); //3
            }
        }
        if (GameObject.FindObjectOfType<playerController>().score >= 5 && GameObject.FindObjectOfType<playerController>().score < 15)
        {
            if (timer >= 70)
            {
                timer = 0;
                GameObject pipe = Instantiate(pipes, new Vector2(pipes.transform.position.x , pipes.transform.position.y + Random.Range(-2, 2)), pipes.transform.rotation);//-2 2
                Destroy(pipe, 3f); //3
            }
        }
        if (GameObject.FindObjectOfType<playerController>().score >= 15)
        {
            if (timer >= 40)
            {
                timer = 0;
                GameObject pipe = Instantiate(pipes, new Vector2(pipes.transform.position.x + Random.Range(-1,-1), pipes.transform.position.y + Random.Range(-2, 2)), pipes.transform.rotation);//-2 2
                Destroy(pipe, 2.5f); //3
            }
        }
        if (GameObject.FindObjectOfType<playerController>().score >= 35)
        {
            if (timer >= 40)
            {
                timer = 0;
                GameObject pipe = Instantiate(pipes, new Vector2(pipes.transform.position.x + Random.Range(-2, -2), pipes.transform.position.y + Random.Range(-2, 2)), pipes.transform.rotation);//-2 2
                Destroy(pipe, 2f); //3
            }
        }
    }
}