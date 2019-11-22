using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ActivateVFX : MonoBehaviour
{
    // Start is called before the first frame update
    public string scene;
    public GameObject VR;
    public Animator anim;
    public Collider picture;
    public GameObject black_hole;
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
       if(anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f){
           Debug.Log("ffffffffffffffffffffffffff");
           //Valve.VR.OpenVR.System.ResetSeatedZeroPose();
           SceneManager.LoadSceneAsync(scene);
           //VR.transform.position = new Vector3(3.5f,0,0);
       }
    }
    void OnTriggerEnter(Collider n)
    {
        if (n.gameObject.tag == "Hand")
        {
            black_hole.SetActive(true);
            Debug.Log("ffffffffffffffffffffffffff");
            //Initiate.Fade(scene,Color.black, 1.0f);
            // SceneManager.LoadSceneAsync(scene);
            // VR.transform.position = new Vector3(3.5f,0,0);
            // Valve.VR.OpenVR.System.ResetSeatedZeroPose();
            // Debug.Log("Inside");
            //player.transform.parent = transform;
        }
    }
}
