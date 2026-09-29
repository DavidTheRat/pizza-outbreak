using UnityEngine;



namespace TopDown.Movement
{ 
    public class rotator : MonoBehaviour
    {
        private void Update()
        {
            transform.LookAt(Vector3.zero);
        }
    }
}