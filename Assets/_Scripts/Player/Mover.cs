using UnityEngine;
using UnityEngine.InputSystem;

namespace Topdown.Movement
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Movement : MonoBehaviour
    {

        [SerializeField] private float movementSpeed = 5;
        [SerializeField] private Rigidbody2D body;
        private Vector2 currentInput;

        public void Move(InputAction.CallbackContext context)
        {
            Debug.Log("Move has run");
            currentInput = context.ReadValue<Vector2>();
            if(currentInput.sqrMagnitude > 1)
            {
                currentInput = currentInput.normalized;
            }
        }

        private void Awake()
        {
            body = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            body.linearVelocity = movementSpeed * currentInput;
        }
    }
}
