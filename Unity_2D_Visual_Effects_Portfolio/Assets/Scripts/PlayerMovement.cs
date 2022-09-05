using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	[SerializeField] private float jumpSpeed = 5.0f;

	private Rigidbody2D playerRB = null;


    // Start is called before the first frame update
    void Start()
    {
	    playerRB = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
	    if (Input.GetKeyDown(KeyCode.Space) && JumpCollider.playerGrounded)
	    {
		    playerRB.AddForce(new Vector2(0.0f,jumpSpeed), ForceMode2D.Impulse);
	    }
    }
}
