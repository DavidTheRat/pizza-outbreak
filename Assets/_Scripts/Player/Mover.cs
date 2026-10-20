using UnityEngine;

namespace Topdown.Movement
{
    [RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
    {

        [SerializeField] private float movementSpeed;
    private Rigidbody2D body;
    private Vector2 currentInput;
    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

        private void FixedUpdate()
        {
            body.linearVelocity = movementSpeed * currentInput * Time.fixedDeltaTime; 
        }
    }
}
