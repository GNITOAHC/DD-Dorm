using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TogglePhone : MonoBehaviour
{
    public GameObject phone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnablePhone() {
        phone.SetActive(true);
    }
    public void DisablePhone() {
        phone.SetActive(false);
    }
}
