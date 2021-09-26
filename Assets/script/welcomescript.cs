using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class welcomescript : MonoBehaviour
{
    public GameObject Welcome;
    private void Start()
    {
        Welcome.SetActive(false);
    }
    public void welcomegame()
    {
        Welcome.SetActive(true);
    }
}
