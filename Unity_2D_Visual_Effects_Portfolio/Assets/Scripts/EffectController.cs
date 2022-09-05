using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectController : MonoBehaviour
{
	[Tooltip("Base dust cloud effect prefab")]
	[SerializeField] private GameObject dustCloudEffect = null;
	[Tooltip("Custom sprite that can be edited at any time during editor mode")]
	[SerializeField] private Sprite defaultDustCloudSprite = null;
	[SerializeField] private Sprite customDustCloudSprite = null;
	[Tooltip("Transform of the player character. \nThis is where the effect will be instantiated")]
	[SerializeField] private Transform playerTransform = null;
	

	private bool effectInstantiated = false;
	private GameObject cloudEffectInstance = null;


	private void Start()
	{
		if (!customDustCloudSprite)
		{
			dustCloudEffect.GetComponentInChildren<ParticleSystem>().textureSheetAnimation.SetSprite(0, defaultDustCloudSprite);
		}
		else if (customDustCloudSprite)
		{
			dustCloudEffect.GetComponentInChildren<ParticleSystem>().textureSheetAnimation.SetSprite(0, customDustCloudSprite);
		}
	}

	// Update is called once per frame
	void Update()
    {
	    if (JumpCollider.playerGrounded && !effectInstantiated)
	    {
		    cloudEffectInstance = Instantiate(dustCloudEffect, playerTransform);
			effectInstantiated = true;
	    }

		else if (!JumpCollider.playerGrounded && effectInstantiated)
	    {
		    effectInstantiated = false;
		}
    }
}
