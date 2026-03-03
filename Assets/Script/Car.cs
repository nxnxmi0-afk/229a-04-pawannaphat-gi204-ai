using UnityEngine;
using UnityEngine.InputSystem;

public class CarController : MonoBehaviour
{
    public float speed = 20f;
    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float move = 0f;

        if (Keyboard.current.wKey.isPressed)
            move = 1f;
        if (Keyboard.current.sKey.isPressed)
            move = -1f;

        rb.AddForce(transform.up * move * speed);
    }
}