using Unity.Mathematics;
using UnityEngine;

public class enemyscript : MonoBehaviour{
    public Transform target;
    public float speed = 5f;
    public float rotatespeed = 0,0025f;
    private Rigidbody2D rb;

    private void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update(){
        if (!target) {
            GetTarget ();
        }
        else{
            RotateTowardsTarget();
        }
    
    }
    private void FixedUpdate(){
        
    }

    private void RotateTowardsTarget(){
        Vector2 targetDirection = target.position - transform.position;
        float angle = Mathf.Atan2(targetDirection.y, targetDirection.x) * Mathf.Rad2Deg - 90f;
        quaternion q = quaternion.Euler(new Vector3(0, 0, angle));
        transform.localRotation = quaternion.Slerp(transform.localRotation,q,rotatespeed);
    }
    private void GetTarget(){
       target = GameObject.FindGameObjectWithTag("Player").transform;
    }
}
