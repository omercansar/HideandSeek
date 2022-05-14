using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class control : MonoBehaviour
{
	  public float movementSpeed = 1f;
	  Rigidbody2D rbody;
	//  private bool facingRight = true;

	  //public Animator animator;
	  
    // Start is called before the first frame update
    void Awake()
    {
      rbody = GetComponent<Rigidbody2D>();
      DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
	   
	     Vector2 currentPos = rbody.position;
	 float horizontalInput = Input.GetAxis("Horizontal");
	 float verticalInput = Input.GetAxis("Vertical");
	// animator.SetFloat("Speed", Mathf.Abs(horizontalInput + verticalInput));
	 Vector2 inputVector = new Vector2(horizontalInput, verticalInput);
	 Vector2 movement = inputVector * movementSpeed;
	 Vector2 newPos = currentPos + movement * Time.fixedDeltaTime;
	// if (horizontalInput > 0 &&!facingRight)
	//	 Flip ();
	 //else if (horizontalInput < 0 && facingRight)
		// Flip ();
	 rbody.MovePosition(newPos);

	 
    }

    void OnTriggerEnter2D(Collider2D slow)
    {
	    if (slow.gameObject.tag == "Water")
	    {
		    movementSpeed -= 15f;
	    }
    }

    private void OnTriggerExit2D(Collider2D fast)
    {
	    if (fast.gameObject.tag == "Water")
	    {
		    movementSpeed += 15f;
	    }
    }
    //void Flip ()
  //  {
	   // facingRight = !facingRight;
	    //Vector3 theScale = transform.localScale;
	    //theScale.x *= -1;
	    //transform.localScale = theScale;
    //}
}
