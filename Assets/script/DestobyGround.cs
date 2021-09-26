using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DestobyGround : MonoBehaviour
{
    public Text Eggds;
    public
      Gameover gameover;
    public
      GameObject stopinitiate;
    private int s=0;
    // Start is called before the first frame update
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Egg")
        {
            Destroy(other.gameObject);
            s++;
        }
        if (s == 10)
        {
            gameover.gameoverend();
            stopinitiate.SetActive(false);

        }
        if ((other.gameObject.tag == "Orange")||(other.gameObject.tag == "Boom"))
        {
            Destroy(other.gameObject);
          
        }

       
    }
    void Update()
    {
        Eggds.text = s.ToString();
    }

}
