using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seek : MonoBehaviour
{
    [SerializeField] private Transform target;

    private UnityEngine.AI.NavMeshAgent agent;


    private float xPositionOnPreviousFrame;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
        float xtrans = transform.position.x;
        if (xPositionOnPreviousFrame >= xtrans)
        {
            Flip(false);
        }
        else if (xPositionOnPreviousFrame <= xtrans)
        {
            Flip(true);
        }

        xPositionOnPreviousFrame = xtrans;
    }

    void Flip(bool lookRight)
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
}
