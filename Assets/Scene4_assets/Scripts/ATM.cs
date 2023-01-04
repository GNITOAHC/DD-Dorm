using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ATM : MonoBehaviour
{
    [Header("Canvas-Vid6")] public GameObject Canvas_Vid6;
    [Header("X button of Canvas-Vid6")] public GameObject XButton_Vid6;
    private bool withDrawAlready = false;
    Scene4_GameManager gameManager;
    Scene4_PhoneManager phoneManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<Scene4_GameManager>();
        phoneManager = FindObjectOfType<Scene4_PhoneManager>();
    }

    // Update is called once per frame
    void Update()
    {
        XButton_Vid6.GetComponent<Button>().onClick.AddListener(() => Canvas_Vid6.SetActive(false));
    }

    private void OnMouseDown() {
        Debug.Log("ATM: OnMouseDown");
        if (!gameManager.getOrderMachineAlready()) return;
        if (withDrawAlready) return;
        else {
            phoneManager.ActivateVid7();
            Canvas_Vid6.SetActive(true);
            gameManager.setAtmAlready(true);
            withDrawAlready = true;
        }
    }
}
