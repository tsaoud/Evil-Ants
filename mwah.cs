using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mwah : MonoBehaviour
{
    public GameObject mwahShot;

    void OnCollisionEnter2D(Collision2D collision)
    {
        //Destroy(gameObject);

        if (collision.gameObject.tag == "BlueAnt")
        {
            Destroy(collision.gameObject);
            Destroy(mwahShot);
        }
    }
}
