using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class ObstacleSlider : MonoBehaviour
{
    public List<Transform> wayPoints;

    private Transform destination;
    private NavMeshAgent agent;
    private int i;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        destination = wayPoints[i];
    }

    // Update is called once per frame
    void Update()
    {
        //patrolling for sliding
        agent.destination = destination.position;

        if (!agent.pathPending && agent.remainingDistance < 0.5f)
        {
            i = (i + 1) % wayPoints.Count;
            destination = wayPoints[i];
        }
    }
}
