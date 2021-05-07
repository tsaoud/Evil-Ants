using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBulletsUI : MonoBehaviour
{

    Text text;
    public PlayerShooting targetShooting;

    void Awake()
    {
        text = GetComponent<Text>();  
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Bullets: " + targetShooting.bulletsAmount;
    }
}
