using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class WaveSpawner : MonoBehaviour
//{

//    public GameObject prefab; //prefab to spawn
//    public float startTime; //time to start wave spawning
//    public float endTime; //time to end wave spawning
//    public float spawnRate; //time between each spawn

//    // Start is called before the first frame update
//    void Start()
//    {
//        InvokeRepeating("Spawn", startTime, spawnRate);
//        Invoke("CancelInvoke", endTime);
//    }

//    void Spawn()
//    {
//        Instantiate(prefab, transform.position, transform.rotation);
//    }

//    // Update is called once per frame
//    void Update()
//    {
        
//    }
//}


public class WaveSpawner : MonoBehaviour
{
    public GameObject prefab;
    public float startTime;
    public float endTime;
    public float spawnRate;

    void Start()
    {
        WaveManager.instance.AddWave(this);
        InvokeRepeating("Spawn", startTime, spawnRate);
        Invoke("EndSpawner", endTime);
    }

    void Spawn()
    {
        Instantiate(prefab, transform.position, transform.rotation);
    }

    void EndSpawner()
    {
        WaveManager.instance.RemoveWave(this);
        CancelInvoke();
    }
}