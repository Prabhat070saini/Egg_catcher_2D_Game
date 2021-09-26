using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inisitationeggboom : MonoBehaviour
{
    //  public Transform box;
    public GameObject prefabb;
    private GameObject copyboom, copyEgg, copyorange;
    public GameObject prefabE;
    public GameObject prefabO;
    public float eggtime = 3.0f, boomtime = 4.0f, orangetime = 8.0f;
    public float firstegg = 0.0f, firstboom = 5.0f, firstorange = 8.0f;
   
    //  public Movementhen hn;

    // Start is called before the first frame update
    void Start()
    {

        // Instantiate(prefabb, new Vector2(0,0), Quaternion.identity);

    }
    public GameObject canvax;

   
    void Update()
    {
        //  Debug.Log("helloprabhat");
        // Instantiate(prefab, new Vector3(0, 20, 0), Quaternion.identity);
        if (Time.time > firstegg)
        {
            firstegg = Time.time + eggtime;
            copyEgg = Instantiate(prefabE, new Vector3(Random.Range(1.0f, Screen.width - 2.0f), Screen.height, 0), Quaternion.identity);
            copyEgg.transform.SetParent(canvax.transform);
        }
        if (Time.time > firstboom)
        {
            // copyboom = Instantiate(prefab, new Vector3(Random.Range(), 213, 0), Quaternion.identity);
            firstboom = Time.time + boomtime;
            copyboom = Instantiate(prefabb, new Vector3(Random.Range(1.0f, Screen.width - 2.0f), Screen.height, 0), Quaternion.identity);
            copyboom.transform.SetParent(canvax.transform);
        }
        if (Time.time > firstorange)
        {
            // copyboom = Instantiate(prefab, new Vector3(Random.Range(), 213, 0), Quaternion.identity);
            firstorange = Time.time + orangetime;
            copyorange = Instantiate(prefabO, new Vector3(Random.Range(1.0f, Screen.width - 2.0f), Screen.height, 0), Quaternion.identity);
            copyorange.transform.SetParent(canvax.transform);
        }


      

    }
}