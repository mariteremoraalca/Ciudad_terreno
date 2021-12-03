using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WavesSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject prefab;
    [SerializeField]
    private float startTime;
    [SerializeField]
    private float endTime;
    [SerializeField]
    private float spawnRate;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", startTime, spawnRate);
        Invoke("CancelInvoke", endTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Spawn()
    {
        GameObject clone = Instantiate(prefab);
        clone.transform.position = transform.position;
        clone.transform.rotation = transform.rotation;
    }
}
