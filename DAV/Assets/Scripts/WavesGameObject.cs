using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WavesGameObject : MonoBehaviour
{
    [SerializeField]
    Life playerlife;
    [SerializeField]
    Life playerBaseLife;


    // Start is called before the first frame update
    void Start()
    {
        playerlife.onDeath.AddListener(OnPlayerLifeChanged);
        playerBaseLife.onDeath.AddListener(OnPlayer)
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyManager.instance.enemies.Count <= 0 &&
           WavesManager.instance.waves.Count <= 0)
        {
            print("GANAAASTEEE")
        }
        if (playerLife.amount <= 0)
        {
            print("Perdiste buuuh")
        }
    }
}
            
