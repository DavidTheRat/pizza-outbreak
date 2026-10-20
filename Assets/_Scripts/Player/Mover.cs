using UnityEngine;
using UnityEngine.InputSystem;

namespace Topdown.Movement
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Movement : MonoBehaviour
    {

        [SerializeField] private float movementSpeed = 5;
        private Rigidbody2D body;
        private Vector2 currentInput;

        public void Move(InputAction.CallbackContext context)
        {

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

        private void FixedUpdate()
        {
            body.linearVelocity = movementSpeed * currentInput;
        }
    }
}
