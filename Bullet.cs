using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public GameObject blueAnt;

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);

        if (collision.gameObject.tag == "RedAnt")
        {
            GameObject iceAnt = Instantiate(blueAnt, transform.position, Quaternion.identity);

            Destroy(collision.gameObject);
        }
    }
}
