using System.Collections;
using System.Collections.Generic;
 using UnityEngine;
public class Movement : MonoBehaviour
{
    public GameObject bukt;
    private float screenCenterX;

    private void Start()
    {
        // save the horizontal center of the screen
        screenCenterX = Screen.width * 0.5f;
    }

    private void Update()
    {
        // if there are any touches currently
        if (Input.touchCount > 0)
        {
            // get the first one
            Touch firstTouch = Input.GetTouch(0);

            // if it began this frame
            if (firstTouch.phase == TouchPhase.Began)
            {
                if (firstTouch.position.x > screenCenterX)
                {
                    bukt.transform.position = new Vector3(transform.position.x + firstTouch.deltaPosition.x * 0.10f, transform.position.y,transform.position.z);
                }
                else if (firstTouch.position.x < screenCenterX)
                {
                    bukt.transform.position = new Vector3(transform.position.x - firstTouch.deltaPosition.x * 0.10f, transform.position.y, transform.position.z);
                 
                }
            }
        }
    }
}
