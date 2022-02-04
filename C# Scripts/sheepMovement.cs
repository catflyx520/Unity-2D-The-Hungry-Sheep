using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sheepMovement : MonoBehaviour
{
    public float speed = 10.4f;
    public static bool isDropped = false;
    public static Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        if (Input.GetKeyUp(KeyCode.Space))
        {
            isDropped = true;
            sheepMovement.rb.gravityScale = 0.9f;
        }


        if (!isDropped)
        {
            if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
            {
                pos.x += speed * Time.deltaTime;
            }
            if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
            {
                pos.x -= speed * Time.deltaTime;
            }

            transform.position = pos;
        }
        else
        {
            
          //  Debug.Log("The drop button has been pressed.");
           // Debug.Log(rb.gravityScale);
            
        }

   
    }
}
