using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class AnimatorController : MonoBehaviour {
    
     public Animator animator;
    
    // Use this for initialization
    void Start () {
       animator = GetComponent<Animator>();
    }
    
    // Update is called once per frame
    void Update () {
        bool walk = Input.GetButtonDown("Fire1");
        

        if (Input.GetKey(KeyCode.E))
       {
        walk=true;
       }
       animator.SetBool("walk", walk);
    }

    void OnCollisionEnter(Collision col) {
        if (col.gameObject.CompareTag("Enemy"))
        {
            animator.SetTrigger("Die");
        }
    }
}