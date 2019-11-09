using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

    
    public class MoveTo : MonoBehaviour {
       
       public Transform goal;
       public Transform goal2;
       public GameObject[] waypoints;
       int current = 0;
       float WPradius = 1;

       public Animator animator;
       public NavMeshAgent nav;

       float timeLeft = 5.0f;

       void Start () {
           animator = GetComponent<Animator>();
       }
       void Update () {
         bool walk = Input.GetButtonDown("Fire1");
         bool turn = Input.GetButtonDown("Fire1");

         timeLeft -= Time.deltaTime;
         Debug.Log(timeLeft);
         if(timeLeft<=0){
            //turn=true;
            timeLeft = 10.0f;  
         

            //transform.LookAt(goal);
            if(Vector3.Distance(waypoints[current].transform.position, transform.position) < WPradius)
            {
               
               current = Random.Range(0,waypoints.Length);

               if (current >= waypoints.Length)
               {
                  
                  timeLeft = 5.0f;
                  current = 0;
               }
            }
            NavMeshAgent agent = GetComponent<NavMeshAgent>();
            agent.destination = waypoints[current].transform.position;
         }
         //---------------------------------

         
         if(nav.angularSpeed>1){
               //Debug.Log(nav.angularSpeed);
               walk=false;
               //turn=true;            
            }
         if(nav.remainingDistance>0.5){
               //Debug.Log("massss");
               walk=true;
               //turn=false;
            }
            animator.SetBool("walk", walk);
            animator.SetBool("turn", turn);
         }
}