
using UnityEngine;
using UnityEngine.InputSystem;


[RequireComponent(typeof(Rigidbody2D))]
public class topdownmovement : MonoBehaviour
{

    [SerializeField] private float moveSpeed = 5f;

    [SerializeField] private InputActionReference moveActionReference;



    private Rigidbody2D rb;

    private Vector2 MoveInput;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + MoveInput.normalized *
        moveSpeed * Time.fixedDeltaTime);
    }


    void OnEnable()
    {
        moveActionReference.action.Enable();
        moveActionReference.action.performed += OnMovePerformed;
        moveActionReference.action.canceled += OnMoveCancelled;
    }
    void OnDisable()
    {
        moveActionReference.action.performed -= OnMovePerformed;
        moveActionReference.action.canceled -= OnMoveCancelled;
        moveActionReference.action.Disable();
    }
    private void OnMovePerformed(InputAction.CallbackContext ctx)
    {
        MoveInput = ctx.ReadValue<Vector2>();
    }

    private void OnMoveCancelled(InputAction.CallbackContext ctx)
    {
        MoveInput = Vector2.zero;
    }


   
}