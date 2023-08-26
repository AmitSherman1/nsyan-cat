using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    [SerializeField] GameObject GameOver;
    public Animator PlayerAnimator;

    public void Retry()
    {
        GameOver.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Home(int sceneID)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneID);
    }

    private void OnTriggerEnter2D(Collider2D Player)
    {
        if (Player.CompareTag("Apple"))
        {
            GameOver.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
