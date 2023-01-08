using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBackpackIcon : MonoBehaviour
{
    public GameObject NoElephant;
    public GameObject WithElephant;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Change() {
        NoElephant.SetActive(false);
        WithElephant.SetActive(true);
    }
}
