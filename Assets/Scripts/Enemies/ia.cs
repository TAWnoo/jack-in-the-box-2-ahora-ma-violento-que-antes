using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ia : MonoBehaviour
{

    public UnityEngine.AI.NavMeshAgent enemigo;
    public Transform target;
    

    void Start()
    {
        enemigo = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    

    void Update()
    {
        enemigo.destination = target.position;
    }
}
