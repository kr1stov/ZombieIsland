﻿using System;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : GameEntity {

    public NavMeshAgent Agent;
    public float RandomDestinationRadius;

    public bool HasReachedDestination
    {
        get { return Agent.pathStatus == NavMeshPathStatus.PathComplete;}
    }

    // Use this for initialization
	void OnEnable () {
        GameManager.Instance.RegisterGameEntity(this);
        PickRandomDestination();
	}

    private void OnDisable()
    {
        GameManager.Instance.UnregisterGameEntity(this);
    }

    private void OnDestroy()
    {
        GameManager.Instance.UnregisterGameEntity(this);
    }

    public override void UpdateSelf()
    {
        if (HasReachedDestination)
            PickRandomDestination();
    }

    void PickRandomDestination()
    {
        Vector3 randomPoint = UnityEngine.Random.insideUnitSphere * RandomDestinationRadius;
        NavMeshHit hit;

        if (NavMesh.SamplePosition(randomPoint, out hit, RandomDestinationRadius*2, NavMesh.AllAreas))
        {
            Agent.SetDestination(hit.position);  
        }
    }
}
