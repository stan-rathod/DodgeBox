using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed = 0.0f;
    private Rigidbody playerRigidbody;

    // Use this for initialization
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate()
    {
        Move();
	}

    private void Move()
    {
        if(Input.GetAxis("Horizontal") != 0)
        {
            float horizontalAxis = Input.GetAxis("Horizontal");
            Vector3 moveDirection = new Vector3(horizontalAxis, 0, 0);
            playerRigidbody.velocity = moveDirection * movementSpeed * Time.fixedDeltaTime;
        }
    }
}
