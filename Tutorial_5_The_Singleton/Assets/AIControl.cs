using UnityEngine;
using UnityEngine.AI;

public class AIControl : MonoBehaviour {

	NavMeshAgent agent;
    Animator anim;
    Vector3 lastGoal;


	// Use this for initialization
	void Start ()
	{
		agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
        anim.SetBool("isWalking", true);
        PickGoalLocation();
	}

    void PickGoalLocation()
    {
        lastGoal = agent.destination;
        GameObject goalPos = GameEnvironment.Singleton.GetRandomGoal();
        agent.SetDestination(goalPos.transform.position);
    }

	
	// Update is called once per frame
	void Update () {
        if (agent.remainingDistance < 1) //At the goal
        {
            PickGoalLocation();
        }

        foreach (var go in GameEnvironment.Singleton.Obstacles)
        {
	        float distance = Vector3.Distance(go.transform.position, transform.position);
	        if (distance<5 && Random.Range(0,100)<5)
		        agent.SetDestination(lastGoal);
	        else if (distance < 1)
	        {
		        GameEnvironment.Singleton.RemoveObstacles(go);
		        break;
	        }
        }
	}
}
