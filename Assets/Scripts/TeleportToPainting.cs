using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class TeleportToPainting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(gameObject.name);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnHandHoverBegin()
    {
        print(gameObject.name);
        SceneManager.LoadScene(gameObject.name);
    }
}
