using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class AIController : MonoBehaviour
{
    NavMeshAgent Agent;
    public GameObject target;
    void Start()
    {
        Agent = GetComponent<NavMeshAgent>();
        
    }

    
    void Update()
    {
        Agent.SetDestination(target.transform.position);
    }
}
