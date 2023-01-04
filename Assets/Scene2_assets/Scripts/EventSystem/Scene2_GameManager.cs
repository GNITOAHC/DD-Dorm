using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Scene2_GameManager : MonoBehaviour
{
    // Private Variables
    private bool GetLieTestResult = false, GetCleaningSheet = false;
    private BackpackManager Backpack;
    private PhoneManager Phone;
    // Public Variables
    [Header("Canvas_LieTestResult")] public GameObject Canvas_LieTestResult;
    [Header("Canvas_CleaningSheet")] public GameObject Canvas_CleaningSheet;
    [Header("Button GetProp from Canvas_LieTestResult")] public Button GetProp;
    [Header("Button X-button from Canvas-CleaningSheet")] public Button X_button;
    // Start is called before the first frame update
    void Start()
    {
        // Get functions
        Backpack = FindObjectOfType<BackpackManager>();
        Phone = FindObjectOfType<PhoneManager>();

        // Initialize the backpacks
        Backpack.BackpackStage(1); // Backpack nothing

        // Initialize the phone 
        Phone.phoneStage(1); // Phone Vid 1
        
        GetProp.GetComponent<Button>().onClick.AddListener(CloseLieUI);
        X_button.GetComponent<Button>().onClick.AddListener(CloseCleanUI);    
    }

    // Update is called once per frame
    void Update()
    {
        if (GetLieTestResult && GetCleaningSheet) {
            changePhone();
        }
    }

    public void getLieTestResult() {
        if (GetLieTestResult) return; // If get LieTestResult already
        // Else 
        GetLieTestResult = true;
        Canvas_LieTestResult.SetActive(true);
        Backpack.BackpackStage(2); // Backpack LieTestResult
    }

    public void getCleaningSheet() {
        if (GetCleaningSheet) return; // If get cleaning sheet already
        // Else
        GetCleaningSheet = true;
        Canvas_CleaningSheet.SetActive(true);
        Transform Cleanbtn = Canvas_CleaningSheet.GetComponent<Transform>().GetChild(2);
        Cleanbtn.GetComponent<Button>().onClick.AddListener(CloseCleanUI);
    }

    private void CloseLieUI() {
        Canvas_LieTestResult.SetActive(false);
    }
    private void CloseCleanUI() {
        Canvas_CleaningSheet.SetActive(false);
    }
    private void changePhone() {
        Debug.Log("ChangePhone");
        Phone.phoneStage(2); // Phone Vid 2
    }
}
