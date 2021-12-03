using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFSM : MonoBehaviour
{
    public Sight sightSensor;
    public enum EnemyState { GoToBAse, AttackBase, ChasePlayer, AttackPlayer }
    public EnemyState currentState;
    public Transform baseTransform;
    public float 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (currentState == EnemyState.GoToBase)
        {
            GoToBase();
        }
    }
        else if (currentSate == EnemyState.AttackBase)
        {
            AttackBase();
        }
        else if (currentState == EnemyState.AttackPlayer) { }

    void GoToBase()
    {
        //print("Go to base");
        if (sightSensor.detectedObject ! = null)
        {
            currentState = EnemyState.ChasePlayer;
        }
    float distanceToBase = Vector3.Distance(transform.position, baseTransform.position);
    }
    void AttackBase()
    {
        print("Attack base");
    }
    void ChasePlayer()
    {
        print("Chase Player");
    }
    void AttackPlayer()
    {
        print("attack player");
    }
}
