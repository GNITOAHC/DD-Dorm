using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class BackPackLieTestResult : MonoBehaviour
{
    public GameObject Backpack, CanvasLieTestResult;
    // Start is called before the first frame update
    void Start()
    {
        // Find BackpackIcon
        Button backpackIcon = GameObject.Find("BackpackIcon").GetComponent<Button>();
        // Find X-Button of backpack 
        Button X_backpack = transform.Find("Backpack/X-Button").GetComponent<Button>();
        // Find LieTest-Button of Backpack
        Button lieTestBtn = transform.Find("Backpack/LieTest-Button").GetComponent<Button>();
        // Find X-Button of Canvas-LieTestResult
        Button X_LieTest = transform.Find("Canvas-LieTestResult/X-Button").GetComponent<Button>();

        // Buttons actions
        backpackIcon.onClick.AddListener(() => Backpack.SetActive(true));
        X_backpack.onClick.AddListener(() => Backpack.SetActive(false));
        lieTestBtn.onClick.AddListener(() => CanvasLieTestResult.SetActive(true));
        X_LieTest.onClick.AddListener(() => CanvasLieTestResult.SetActive(false));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
