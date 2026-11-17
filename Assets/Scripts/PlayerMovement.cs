using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 5f;

    private Rigidbody2D rb;// Reference to the Rigidbody2D component
    private Vector2 movementInput;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();// Get the Rigidbody2D component attached to the player
    }
void Update()
{
    Vector2 input = Vector2.zero;

    if (Keyboard.current != null)
    {
        if (Keyboard.current.wKey.isPressed)
            input.y += 1;

        if (Keyboard.current.sKey.isPressed)
            input.y -= 1;

        if (Keyboard.current.dKey.isPressed)
            input.x += 1;

        if (Keyboard.current.aKey.isPressed)
            input.x -= 1;
    }

    movementInput = input.normalized;
}

    void FixedUpdate()
    {
        rb.linearVelocity = movementInput * moveSpeed;// Set the Rigidbody2D's velocity based on movement input and speed
    }
}
 