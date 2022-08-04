using UnityEngine.SceneManagement;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    void Start()
    {       
    }
    public void EndGame()
    {       
        Invoke("Restart", 1f);
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
