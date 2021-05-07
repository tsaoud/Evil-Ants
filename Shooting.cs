using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameObject mwahPrefab;

    public float bulletForce = 20f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shootBullet();
        }

        if (Input.GetButtonDown("Fire2"))
        {
            shootMwah();
        }
    }

    void shootBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb1 = bullet.GetComponent<Rigidbody2D>();
        rb1.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }

    void shootMwah()
    {
        GameObject mwah = Instantiate(mwahPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb2 = mwah.GetComponent<Rigidbody2D>();
        rb2.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}
