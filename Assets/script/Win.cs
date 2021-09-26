using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Win : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Winpanal;
    public void gamewin()
    {
        Winpanal.SetActive(true);
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
