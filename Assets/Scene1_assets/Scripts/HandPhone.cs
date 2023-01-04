using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HandPhone : MonoBehaviour
{
    public GameObject Canvas_PhoneUI;
    Scene1_GameManager funcPhoneCanToggle;
    // Start is called before the first frame update
    void Start()
    {
        // Find function 
        funcPhoneCanToggle = FindObjectOfType<Scene1_GameManager>();

        // Find ToKitchenBTN
        Transform obj = Canvas_PhoneUI.GetComponent<Transform>().Find("ToKitchenBTN");
        Button toKitchenBtn = obj.GetComponent<Button>();

        // ToKitchenBTN
        toKitchenBtn.onClick.AddListener(() => SceneManager.LoadScene("Scene2"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        if (!funcPhoneCanToggle.GetCanToggle()) return; // Phone can't toggle
        Canvas_PhoneUI.SetActive(true);
    }
}
