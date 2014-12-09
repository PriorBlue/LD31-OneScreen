using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{

    public Transform oldPointer;
    public float robotSpeed = 60f;
    public Vector3 movementDirection;
    
    void FixedUpdate()
    {
        movementDirection.Set(0, 0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            movementDirection = movementDirection + transform.forward;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            movementDirection = movementDirection - transform.forward;
        }
        if (Input.GetKey(KeyCode.A))
        {
            movementDirection = movementDirection - transform.right;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            movementDirection = movementDirection + transform.right;
        }
        rigidbody.AddForce(Vector3.Normalize(movementDirection) * robotSpeed);
    }
}
