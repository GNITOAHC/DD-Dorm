using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Camera : MonoBehaviour
{
    public Camera[] cameras;
    private int currentCameraIdx;

    // Start is called before the first frame update
    void Start()
    {
        currentCameraIdx = 0;
        for (int i = 1; i < cameras.Length; ++i) cameras[i].gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)) { // Switch to next camera
            ++currentCameraIdx;
            if (currentCameraIdx < cameras.Length)
             {
                 cameras[currentCameraIdx-1].gameObject.SetActive(false);
                 cameras[currentCameraIdx].gameObject.SetActive(true);
                 Debug.Log ("Camera with name: " + cameras [currentCameraIdx].GetComponent(name) + ", is now enabled");
             }
             else
             {
                 cameras[currentCameraIdx-1].gameObject.SetActive(false);
                 currentCameraIdx = 0;
                 cameras[currentCameraIdx].gameObject.SetActive(true);
                 Debug.Log ("Camera with name: " + cameras [currentCameraIdx].GetComponent(name) + ", is now enabled");
             }
        }
    }
}
