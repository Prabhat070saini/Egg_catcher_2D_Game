using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
   // public GameObject Egginstiate;
    public GameObject GameOverPanal;
    private void Start()
    {
        GameOverPanal.SetActive(false);
    }
    public void gameoverend()
    {
        GameOverPanal.SetActive(true);
    }
    public void Restar()
    {
           SceneManager.LoadScene("CatchEgg");
                   //  Egginstiate.SetActive(true);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
