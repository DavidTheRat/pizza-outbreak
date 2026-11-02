using Unity.VisualScripting;
using UnityEngine;
namespace TopDown.Shooting
{ 
  public class guncontroler : MonoBehaviour
    {
        // cooldown
        [Header("Cooldown")]
        [SerializeField] private float cooldown = 0.25f;
        private float cooldownTimer;

        //Bullet prefab
        [Header("References")]
        [SerializeField] private GameObject bulletPrefab;
        [SerializeField] private Transform firepoint;
        [SerializeField] private Animator muzzleflashAnimator;

        //Shoot point


        private void Update()
        {
            cooldownTimer += Time.deltaTime;
        }
        private  void Shoot()
        {
            if (cooldownTimer < cooldown) return;

            GameObject bullet = Instantiate(bulletPrefab, firepoint.position, firepoint.rotation, null);
            muzzleflashAnimator.SetTrigger("Shoot");
            cooldownTimer = 0f;
        }

        private void onshoot()
        {
            Shoot();
        }

    }
 
}
