﻿using UnityEngine;
using UnityEngine.AI;

public class AIControl : MonoBehaviour {

	GameObject[] goalLocations;
	NavMeshAgent agent;
    Animator anim;
    Vector3 lastGoal;


	// Use this for initialization
	void Start () {
		goalLocations = GameObject.FindGameObjectsWithTag("goal");
		agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        anim.SetBool("isWalking", true);
        PickGoalLocation();
	}

    void PickGoalLocation()
    {
        lastGoal = agent.destination;
        agent.SetDestination(goalLocations[Random.Range(0, goalLocations.Length)].transform.position);
    }

	
	// Update is called once per frame
	void Update () {
        if (agent.remainingDistance < 1) //At the goal
        {
            PickGoalLocation();
        }
	}
}
