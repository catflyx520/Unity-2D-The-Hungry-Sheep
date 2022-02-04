using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class reachGround : MonoBehaviour
{
    public string LoadScene = "EndScene";
    public float  spawn_time;
    public static Vector3 start_pos;
    public static bool out_of_bound = false;
    

    void Start()
    {
        start_pos = transform.position;
        spawn_time = 1f;
        Debug.Log(start_pos);
        
    }
    void OnBecameInvisible()
    {
        Lives.lives--;
        out_of_bound = true;
        
        

    }

    void Update()
    {
        if(Lives.lives<=0)
        {
            Debug.Log("End Theme");
            SceneManager.LoadScene(LoadScene);
        }
        if (out_of_bound == true)
        {
           
            spawn_time = spawn_time - Time.deltaTime;
            
            sheepMovement.rb.gravityScale = 0f;
            sheepMovement.rb.velocity = new Vector2(0.0f, 0.0f);
            sheepMovement.rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            sheepMovement.rb.constraints = RigidbodyConstraints2D.None;
            sheepMovement.rb.SetRotation(0.0f);
            if (spawn_time <= 0f)
            {   
                sheepMovement.rb.MovePosition(start_pos);
                
                

            } 
            if (spawn_time <= -0.5f)
            {
                sheepMovement.isDropped = false;
                spawn_time = 1f;
                out_of_bound = false;
            }
        
        }
        
    }
}
