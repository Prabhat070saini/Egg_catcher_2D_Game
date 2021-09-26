using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public
class Distory : MonoBehaviour
{
    public
      Text printscore;
    public
      Text printscorewin;
    private
      int score = 0;
    private
      int E = 0, B = 0, O = 0;
    public
      Text PE, PB, PO;
    private
      int store, storeb;
    public
      GameObject stopinitiate;
    public
      Gameover gameover;
    public
      Win win;
    private  float storetime=60;
   
    // Start is called before the first frame update

    public
      void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Egg")
        {
            Destroy(other.gameObject);
            score += 2;
            E++;
        }
        if (other.gameObject.tag == "Boom")
        {
            Destroy(other.gameObject);
            score -= 2;
            B++;
            storeb = B;
        }
        if (other.gameObject.tag == "Orange")
        {
            Destroy(other.gameObject);
            score += 3;
            O++;
        }
        store = score;
    }

  // public  void prabhat()
    //{
        // stopinitiate.SetActive(true);
      //  storetime = Time.time + 60;
       
   // }
    
    // Update is called once per frame
    void Update()
    {

       
        Debug.Log((int)Time.time);
        //change score int to string 
        printscore.text = score.ToString();
        PO.text = O.ToString();
        PB.text = B.ToString();
        PE.text = E.ToString();
            //conditon for losss
        if (storeb == 3)
        {

            stopinitiate.SetActive(false);
            gameover.gameoverend();
            
        }

     
            // condition for win
            if (store > 60)
            {
            stopinitiate.SetActive(false);
            win.gamewin();
                printscorewin.text = score.ToString();

            }


        
    }
 }
