using UnityEngine;
namespace Topdown.Movement
{
    public class rotator : MonoBehaviour

    {
        protected void Lookat(Vector2 target)
        {
            // Calculate angle between transform ond target
            float lookAngle = AngleBetweenTwoPoint(transform.position, target) + 90;

            //Assign the target rotation on the Z axis
            transform.eulerAngles = new Vector3(0, 0, lookAngle);
        }
        private float AngleBetweenTwoPoint(Vector3 a, Vector3 b)
        {
            return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
        }
    }
}