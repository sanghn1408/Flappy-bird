using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class playerController : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    Rigidbody2D bird;
    public int score = 0;
    public int Score 
    {
        get
        {
            return score;
        }
        set
        {        
           score = 0;
        }
    }

    bool dead = false;
    public AudioClip wing;
    public AudioClip point;
    public AudioClip die;
    private AudioSource audioSoure;
    public Animator animator;
    void Start()
    {
        score = 0;
        bird = transform.GetComponent<Rigidbody2D>();
        audioSoure = gameObject.GetComponent<AudioSource>();
      
    }
    public void Update()
    {
        if (Input.GetMouseButton(0) || Input.GetKeyDown("space"))
        {
            audioSoure.clip = wing;
            audioSoure.Play();
            bird.velocity = new Vector2(0, 3f);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }       
        if (dead)
        {
            FindObjectOfType<GameManager>().EndGame();
        }  
    }    
    void OnCollisionEnter2D()
    {
        audioSoure.clip = die;
        audioSoure.Play();
        dead = true;
        //score = 0;
        scoreText.text = "0";
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.tag == "pointTrigger")
        {
            score++;
            scoreText.text = score.ToString();
            audioSoure.clip = point;
            audioSoure.Play();         
        }
    }
}
