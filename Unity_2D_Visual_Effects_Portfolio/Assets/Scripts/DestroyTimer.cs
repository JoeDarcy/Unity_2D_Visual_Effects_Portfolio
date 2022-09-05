using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTimer : MonoBehaviour
{
	[Tooltip("Set time before this game object is destroyed")]
	[SerializeField] private float destroyTimer = 2.0f;

	// Destroy this game object after X seconds
	private void Start()
	{
		Destroy(gameObject, destroyTimer);
	}
}
