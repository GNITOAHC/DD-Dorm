using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1_GameManager : MonoBehaviour
{
    private bool CanToggle;
    // Start is called before the first frame update
    void Start()
    {
        CanToggle = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EnableToggle() {
        CanToggle = true;
    }
    public bool GetCanToggle() {
        return CanToggle;
    }
}
