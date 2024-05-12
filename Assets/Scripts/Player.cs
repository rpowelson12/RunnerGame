using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    [SerializeField] private float jumpHeight;
    private float horizontal;
    private Rigidbody playerRb;

    private void Start(){
        playerRb = GetComponent<Rigidbody>();
    }



    private void Update(){
        horizontal = Input.GetAxisRaw("Horizontal");

        transform.position += new Vector3(horizontal * movementSpeed * Time.deltaTime, 0, 0);

        if(Input.GetKeyDown(KeyCode.Space)){
            playerRb.AddForce(new Vector3(0, jumpHeight, 0));
        }
    }
}
