using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GravitySwitch : MonoBehaviour
{
    public GameObject capsule;
    public Renderer rend;
    public string objectName;
    public int gravitySet;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        objectName = gameObject.name;
        switch (objectName)
        {
            case "gravityDown":
                gravitySet = -1;
                break;
            case "gravityUp":
                gravitySet = 1;
                break;
            case "gravityOff":
                gravitySet = 0;
                break;
            default:
                gravitySet = -1;
                break;
        }
        Physics.gravity = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnHandHoverBegin()
    {
        //capsule = GameObject.Find("gravityOn");
        Physics.gravity = new Vector3(0, gravitySet, 0);
        rend.material.color = rend.material.color * 0.5f;
    }

    void OnHandHoverEnd()
    {
        rend.material.color = rend.material.color * 2f;
    }
}
