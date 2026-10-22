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
        private void OnLook(InputValue value)
        {    
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(value.Get<Vector2>());
            transform.LookAt(mousePosition);
         }
    }
            
        
         
    
}