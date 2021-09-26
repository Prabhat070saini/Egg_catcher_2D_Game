using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterGame : MonoBehaviour
{
    public GameObject main;
    // Start is called before the first frame update
    private void Start()
    {
        main.SetActive(false);
    }

    public void  Entermaingame()
    {
        main.SetActive(true);
    }
   
}
