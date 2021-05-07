using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WavesGameMode : MonoBehaviour
{

    [SerializeField] Life playerLife;
    [SerializeField] Life playerBaseLife;


    void Start()
    {
        playerLife.onDeath.AddListener(OnPlayerLifeChanged);
        playerBaseLife.onDeath.AddListener(OnPlayerBaseLifeChanged);
        EnemiesManager.instance.onChanged.AddListener(CheckWinCondition);
        WaveManager.instance.onChanged.AddListener(CheckWinCondition);
    }


    void CheckWinCondition()
    {
        if (EnemiesManager.instance.enemies.Count <= 0 && WaveManager.instance.waves.Count <= 0)
        {
            SceneManager.LoadScene("WinScreen");
        }
    }

    void OnPlayerLifeChanged()
    {
        if (playerLife.amount <= 0)
        {
            SceneManager.LoadScene("LoseScreen");
        }
    }

    void OnPlayerBaseLifeChanged()
    {
        if (playerBaseLife.amount <= 0)
        {
            SceneManager.LoadScene("LoseScreen");
        }
    }


    //void Awake()
    //{
    //    playerLife.onDeath.AddListener(OnPlayerLifeChanged);
    //}


}
