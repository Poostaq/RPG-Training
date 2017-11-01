using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float rotateSpeed;
    public float forwardSpeed;
    private CharacterController playerController;
	// Use this for initialization
	void Start () {
        playerController = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		if (playerController.isGrounded)
        {

        }
	}
}
