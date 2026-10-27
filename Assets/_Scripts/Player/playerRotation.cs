using TopDown.Movement;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;
namespace TopDown.Movement
{
    public class playerRotation : rotator
    {
        //Determine Mouse position and look that way
        //private void OnLook(InputValue value)
        //{    
        //Vector2 mousePosition = Camera.main.ScreenToWorldPoint(value.Get<Vector2>());
        //    transform.LookAt(mousePosition);
        // }

        Vector3 mousePos;
        Camera mainCam;
        private void Start()
        {
            mainCam = Camera.main;
        }

        private void Update()
        {
            mousePos = mainCam.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            Vector3 rotaion = mousePos - transform.position;
            float angle = Mathf.Atan2(rotaion.y, rotaion.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, angle-90);
        }

    }
            
        
         
}