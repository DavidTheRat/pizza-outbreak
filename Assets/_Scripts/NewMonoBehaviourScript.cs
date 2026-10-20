using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movehorizontal = Input.GetAxis("Horizontal");
        float MoveVertical = Input.GetAxis("Horizontal");

        rb.linearVelocity = new Vector3(movehorizontal, MoveVertical) * speed;
    }
}
