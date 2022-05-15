using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMove : MonoBehaviour
{
    [SerializeField] private Transform target;

    private NavMeshAgent agent;
    public float accelerationTime = 2f;
    public float maxSpeed = 2f;
    private Vector2 movement;
    private float timeLeft;
    public Rigidbody2D rb;
    private float xPositionOnPreviousFrame;
    bool CanSee;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        CanSee = false;
    }

    // Update is called once per frame
    void Update()
    
{
    if (CanSee == true)
        {
            Follow();
            Debug.Log("Follow");
        }
        else
        {
            Rando();
            //Debug.Log("Rando");
        }
    }
    public void PullTrigger(Collider2D c)
    {
        if (c.gameObject.tag == "Player")
        {
            CanSee = true;
        }
    }
        private void Follow()
    {
        agent.SetDestination(target.position);
        /*float xtrans = transform.position.x;
        if (xPositionOnPreviousFrame >= xtrans)
        {
            Flip(false);
        }
        else if (xPositionOnPreviousFrame <= xtrans)
        {
            Flip(true);
        }

        xPositionOnPreviousFrame = xtrans;
        */
    }

   /* void Flip(bool lookRight)
    {
        Vector3 theScale = transform.localScale;
        if (lookRight)
        {
            theScale.x = 1;
        }
        else
        {
            theScale.x = -1;
        }
        transform.localScale = theScale;
    }
    */
    private void Rando()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            movement = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            timeLeft += accelerationTime;
        }

       
    }

    void FixedUpdate()
    {
        rb.AddForce(movement * maxSpeed);
    }
 

    /*private void OnTriggerEnter2D(Collider2D c)
     {
         if (c.gameObject.tag == "Wizard")
         {
            Debug.Log("Your code goes here");
         }
     }*/
}







