using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Gravity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnHandHoverBegin()
    {
        Physics.gravity = new Vector3(0, 1, 0);
    }

    void OnHandHoverEnd()
    {
        Physics.gravity = new Vector3(0, -1, 0);
    }
}
