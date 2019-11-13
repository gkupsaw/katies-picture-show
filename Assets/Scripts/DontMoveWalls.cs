using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontMoveWalls : MonoBehaviour
{
    public Camera cam;
    public Camera cam2;
    // Start is called before the first frame update
    void Start()
    {
        //Camera cam = camera.GetComponent<Camera>();
        //Camera cam = gameObject.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        //cam.enabled = true;
    }
    void OnTriggerEnter(Collider col){
        if(col.tag == "Wall"){
            Debug.Log("collision in walls");
            cam.targetDisplay = 1;
            //transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, 0);
            // cam.enabled = false;
            // cam2.enabled = true;
        }
    }
    void OnTriggerExit(Collider col){
        if(col.tag == "Wall"){
            Debug.Log("exitttttttttttttttttttt");
            cam.targetDisplay = 0;
            // transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, 0);
            // cam.enabled = true;
            // cam2.enabled = false;
        }
    }
}
