using UnityEngine;

public class CarJump : MonoBehaviour
{
    public float jumpScale = 1.2f; // scale of the car when jumping
    private Vector3 initialScale; // store the initial scale of the car

    void Start()
    {
        initialScale = new Vector3(0.7f, 8.5f, 0.7f); // set the initial scale of the car
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with an object tagged "Jump1"
        if (collision.gameObject.tag == "Jump1")
        {
            // Resize the car to the jump scale
            transform.localScale = new Vector3(initialScale.x * jumpScale, initialScale.y * jumpScale, initialScale.z * jumpScale);
        }
        // Check if the collision is with an object tagged "Jump2"
        else if (collision.gameObject.tag == "Jump2")
        {
            // Resize the car to its normal scale
            transform.localScale = initialScale;
        }
    }
}