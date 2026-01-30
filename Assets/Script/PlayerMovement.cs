using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 20f;

    Rigidbody rb;
    Vector3 moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float moveZ = Input.GetAxisRaw("Horizontal"); // A, D
        float moveX = Input.GetAxisRaw("Vertical");   // W, S

        moveInput = new Vector3(moveZ, 0f, moveX).normalized;
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveInput * moveSpeed * Time.fixedDeltaTime);
    }
}
