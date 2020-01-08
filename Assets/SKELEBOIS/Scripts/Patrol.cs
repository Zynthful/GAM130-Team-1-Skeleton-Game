﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Patrol : MonoBehaviour
{
    public NavMeshAgent agent;
    public int wait_time = 3;
    Vector3[] destinations = new[] {new Vector3(20f, 0, 20f),
        new Vector3(20f, 1.5f, -20f),
        new Vector3(-20f, 1.5f, -20f),
        new Vector3(-20f, 1.5f, 20f),};

    public int set_path = 0; 


    // Start is called before the first frame update
    void Start()
    {
        agent.SetDestination(destinations[set_path]);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 current_location = transform.position;
        if (current_location.x == destinations[set_path].x && current_location.z == destinations[set_path].z)
        {
            if (set_path == 3)
            {
                set_path = -1;
            }
            set_path += 1;
            agent.SetDestination(destinations[set_path]);
        }
    }
}
