using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count_Time : MonoBehaviour
{
    public float count = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count += Time.deltaTime;
        if(count > 5) Debug.Log("5 sec");
    }
}
