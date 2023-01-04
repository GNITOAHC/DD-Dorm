using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackpackManager : MonoBehaviour
{
    public GameObject Backpack_Nothing, Backpack_LieTestResult;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BackpackStage(int x) {
        Backpack_Nothing.SetActive(false);
        Backpack_LieTestResult.SetActive(false);
        switch (x) {
            case 1: 
                Debug.Log("Backpack Nothing");
                Backpack_Nothing.SetActive(true);
                break;
            case 2:
                Debug.Log("Backpack LieTest Result");
                Backpack_LieTestResult.SetActive(true);
                break;
            default: 
                Debug.Log("Backpack Failure");
                break;
        }
    }
}
