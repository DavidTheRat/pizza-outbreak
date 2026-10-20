using UnityEngine;
using UnityEngine.InputSystem;
public class playercontrollerTopDown : MonoBehaviour
{
    Vector2 moveDir;
    Rigidbody2D rb;
    public float speed = 5f;
    public void Move(InputAction.CallbackContext context)
    {
        moveDir = context.ReadValue<Vector2>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Vector3 mousePos = Utilsclass;
        rb.linearVelocity = moveDir * speed;
    }
}
