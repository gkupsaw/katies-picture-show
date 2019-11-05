using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ActivateVFX : MonoBehaviour
{
    // Start is called before the first frame update
    public string scene;
    public GameObject VR;
    void Start()
    {
        
        //VR.transform.position = new Vector3(3.5f,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
       {
           Valve.VR.OpenVR.System.ResetSeatedZeroPose();
           SceneManager.LoadSceneAsync("Dynamic Suprematism");
           VR.transform.position = new Vector3(3.5f,0,0);
       }
    }
     void OnTriggerEnter(Collider n)
    {
        if (n.gameObject.tag == "MainCamera")
        {
            //Initiate.Fade(scene,Color.black, 1.0f);
            SceneManager.LoadSceneAsync("Dynamic Suprematism");
            VR.transform.position = new Vector3(3.5f,0,0);
            Valve.VR.OpenVR.System.ResetSeatedZeroPose();
            
            Debug.Log("Inside");
            //player.transform.parent = transform;
        }
    }
}
