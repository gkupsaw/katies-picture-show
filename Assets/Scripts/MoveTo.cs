using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

    
    public class MoveTo : MonoBehaviour {
       
       public Transform goal;
       
       void Start () {
           
       }
       void Update () {
         transform.LookAt(goal);
         // Same as above, but setting the worldUp parameter to Vector3.left in this example turns the camera on its side
         transform.LookAt(goal);
         NavMeshAgent agent = GetComponent<NavMeshAgent>();
         agent.destination = goal.position;
       }
    }