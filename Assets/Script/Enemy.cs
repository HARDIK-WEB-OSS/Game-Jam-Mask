using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent agent;
    public Transform player;

    public float chaseRange = 10f;
    public Transform[] points;

    private int currentPoint;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        Patrol();
    }

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance <= chaseRange)
        {
            ChasePlayer();
        }
        else
        {
            Patrol();
        }
    }

    void ChasePlayer()
    {
        agent.SetDestination(player.position);
    }

    void Patrol()
    {
        if (points.Length == 0)
            return;

        if (!agent.pathPending && agent.remainingDistance <= 0.5f)
        {
            GoToNextPoint();
        }
    }

    void GoToNextPoint()
    {
        currentPoint = Random.Range(0, points.Length);
        agent.destination = points[currentPoint].position;
    }
}
