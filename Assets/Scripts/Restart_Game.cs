using UnityEngine;
using UnityEngine.SceneManagement;
public class Restart_Game : MonoBehaviour
{
    
    void Start()
    {
      
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    void Update()
    {
       
    }
}
