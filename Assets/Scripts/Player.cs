using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    private float horizontal;


    private void Update(){
        horizontal = Input.GetAxisRaw("Horizontal");

        transform.position += new Vector3(horizontal * movementSpeed * Time.deltaTime, 0, 0);
    }
}
