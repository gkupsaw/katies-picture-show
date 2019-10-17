using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityOff : MonoBehaviour

{
    public GameObject capsule;

    // Start is called before the first frame update
    void Start()
    {
        capsule = GameObject.Find("gravityOn");
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnHandHoverBegin()
    {
        Physics.gravity = new Vector3(0, 0, 0);
    }
}
