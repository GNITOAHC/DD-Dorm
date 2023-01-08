using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class BackPackReceipt : MonoBehaviour
{
    public GameObject Backpack, CanvasLieTestResult, CanvasReport, CanvasReceipt;
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
        // Find Report-button of Backpack
        Button reportBtn = transform.Find("Backpack/Report-Button").GetComponent<Button>();
        // Find X-Button of Canvas-Report
        Button X_Report = transform.Find("Canvas-Report/X-Button").GetComponent<Button>();
        // Find Receipt-Button of Backpack
        Button ReceiptBtn = transform.Find("Backpack/Receipt-Button").GetComponent<Button>();
        // Find X-Button of Canvas-Receipt
        Button X_Receipt = transform.Find("Canvas-Receipt/X-Button").GetComponent<Button>();

        // Buttons actions
        backpackIcon.onClick.AddListener(() => Backpack.SetActive(true));
        X_backpack.onClick.AddListener(() => Backpack.SetActive(false));

        lieTestBtn.onClick.AddListener(() => CanvasLieTestResult.SetActive(true));
        X_LieTest.onClick.AddListener(() => CanvasLieTestResult.SetActive(false));

        reportBtn.onClick.AddListener(() => CanvasReport.SetActive(true));
        X_Report.onClick.AddListener(() => CanvasReport.SetActive(false));

        ReceiptBtn.onClick.AddListener(() => CanvasReceipt.SetActive(true));
        X_Receipt.onClick.AddListener(() => CanvasReceipt.SetActive(false));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
