using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class GetChildGM : MonoBehaviour
{
    public GameObject canva;
    // Start is called before the first frame update
    void Start()
    {
        GameObject child = GameObject.Find("Button");
        Button btn = child.GetComponent<Button>();
        btn.onClick.AddListener(() => Debug.Log("onClick"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
