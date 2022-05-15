using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordScript : MonoBehaviour
  
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D c)
    {
        gameObject.GetComponentInParent<AIMove>().PullTrigger(c);
    }
    /*void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wizard")
        {
            CanSee = true;

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wizard")
        {
            CanSee = false;

        }
    }*/

}

