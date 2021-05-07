using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//public class PlayerShooting : MonoBehaviour
//{
//    public GameObject prefab;
//    public GameObject shootPoint;
//    public ParticleSystem muzzleEffect;
//    public int bulletsAmount;

//    Animator animator;

//    float lastShootTime;
//    public float fireRate;


//    void Update()
//    {
//        if (Input.GetKey(KeyCode.Mouse0) && bulletsAmount > 0 && Time.timeScale > 0)
//        {
//            animator.SetBool("Shooting", true);
//            bulletsAmount--;
//            muzzleEffect.Play();

//            var timeSinceLastShoot = Time.time - lastShootTime;
//            if (timeSinceLastShoot < fireRate)
//                return;

//            lastShootTime = Time.time;

//            GameObject clone = Instantiate(prefab);
//            clone.transform.position = shootPoint.transform.position;
//            clone.transform.rotation = shootPoint.transform.rotation;
//        }
//        else
//        {
//            animator.SetBool("Shooting", false);
//        }
//    }

//    void Awake()
//    {
//        animator = GetComponent<Animator>();
//    }

//}



public class PlayerShooting : MonoBehaviour
{
    Animator animator;

    public GameObject prefab;
    public GameObject shootPoint;
    public ParticleSystem muzzleEffect;
    public int bulletsAmount;

    float lastShootTime;
    public float fireRate;

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && bulletsAmount > 0 && Time.timeScale > 0)
        {
            animator.SetBool("Shooting", true);

            var timeSinceLastShoot = Time.time - lastShootTime;
            if (timeSinceLastShoot < fireRate)
                return;

            lastShootTime = Time.time;

            bulletsAmount--;
            muzzleEffect.Play();

            GameObject clone = Instantiate(prefab);
            clone.transform.position = shootPoint.transform.position;
            clone.transform.rotation = shootPoint.transform.rotation;
        }
        else
        {
            animator.SetBool("Shooting", false);
        }
    }

    void Awake()
    {
        animator = GetComponent<Animator>();
    }
}