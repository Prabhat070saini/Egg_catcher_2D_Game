using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movementhen : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool moveleft;
    private bool moveRight;
    private float horizantalMove;
    public float speed = 5.0f;
    public GameObject hen;
    public GameObject bukt;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        moveleft = false;
        moveRight = false;
    }

    public void PointerDownLeft()
    {
        moveleft = true;

    }
    public void PointerDownRight()
    {

        moveRight = true;
    }
    public void PointerUpLeft()
    {
        moveleft = false;

    }
    public void PointerUpRight()
    {

        moveRight = false;
    }
    // Update is called once per frame
    void Update()
    {
        MovementPlayer();
    }
    private void MovementPlayer()
    {
        if ((moveleft)&&(hen.transform.position.x>0))
        {
            horizantalMove = -speed;
        }
        else if ((moveRight)&&(bukt.transform.position.x<Screen.width))
        {
            horizantalMove = speed;
        }
        else
        {
            horizantalMove = 0;
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(horizantalMove, rb.velocity.y, 0);
    }
}
