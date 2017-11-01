using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float moveSpeed = 100.0f;
    public float rotateSpeed = 100.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("w"))
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
            Debug.Log("Pressing W key");
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
            Debug.Log("Pressing S key");
        }
        if (Input.GetKey("d"))
        {
            transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime );
            //transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
            Debug.Log("Pressing D key");
        }
        if (Input.GetKey("a"))
        {
            transform.Rotate(Vector3.back * rotateSpeed * Time.deltaTime);
            //transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
            Debug.Log("Pressing A key");
        }
        if (Input.GetMouseButton(0)) { Debug.Log("Pressing left mouse button"); }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveSpeed = 30.0f;
            Debug.Log("Start of SPRINT");
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed = 5.0f;
            Debug.Log("End of SPRINT");
        }
    }
}
