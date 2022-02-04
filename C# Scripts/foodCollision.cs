using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "food")
        {
            SoundManagerScript.playSound();
            Destroy(col.gameObject);
            score.scores += 100;
        }
    }
}
