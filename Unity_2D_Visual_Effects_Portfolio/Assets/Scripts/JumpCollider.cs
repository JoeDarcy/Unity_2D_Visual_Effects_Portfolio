using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCollider : MonoBehaviour
{
    public static bool playerGrounded = false;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		playerGrounded = true;
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		playerGrounded = false;
	}
}
