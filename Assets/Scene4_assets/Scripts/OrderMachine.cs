using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class OrderMachine : MonoBehaviour
{
    [Header("CanvasVid4&5")] public GameObject CanvasVid4n5;
    [Header("From CanvasVid4&5")]
    [Tooltip("RawImage-Vid4")] public GameObject Vid4;
    [Tooltip("RawImage-Vid5")] public GameObject Vid5;
    [Tooltip("Image-Purse")] public GameObject Purse;
    [Tooltip("Button-UsePurse")] public GameObject UsePurse;
    [Header("OS from CanvasVid4&5")] public GameObject OS;
    [Header("X from OS")] public GameObject ButtonX;
    [Header("Canvas-Pay_Image")] public GameObject PayImage;
    [Header("X from Canvas-Pay_Image")] public GameObject PayImageX;
    [Header("Canvas-UsePurse2")] public GameObject CanvasUsePurse2;
    [Header("useButton from Canvas-UsePurse2")] public GameObject UseButton;

    Scene4_GameManager gameManager;
    // Scene4_PhoneManager phoneManager;
    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<Scene4_GameManager>();
        // phoneManager = FindObjectOfType<Scene4_PhoneManager>();
        InitCanvas();
    }

    // Update is called once per frame
    void Update()
    {
        UsePurse.GetComponent<Button>().onClick.AddListener(() => {
            // Chane to Vid5
            Vid4.SetActive(false);
            Vid5.SetActive(true);
            Purse.SetActive(false);
            UsePurse.SetActive(false);
        });

        ButtonX.GetComponent<Button>().onClick.AddListener(() => {
            Debug.Log("X onclick");
            OS.SetActive(false);
            CanvasVid4n5.SetActive(false);
        });

        if (Vid5.activeSelf) {
            Invoke(nameof(AfterVid5Active), 1f); // 8f
        }

        PayImageX.GetComponent<Button>().onClick.AddListener(() => PayImage.SetActive(false));
        UseButton.GetComponent<Button>().onClick.AddListener(useButtonOnClick);
    }

    private void OnMouseDown() {
        if (!gameManager.getOrderMachineAlready()) {
            Debug.Log("On Mouse Down");
            CanvasVid4n5.SetActive(true);
            Invoke(nameof(ShowPurse), 1f); // 14f
        } else if (gameManager.getOrderMachineAlready() && gameManager.getAtmAlready()){
            PayImage.SetActive(true);
            UsePurse2();
            // gameManager.PlayVid8();
        } else {
            PayImage.SetActive(true);
        }
        gameManager.setOrderMachineAlready(true);
    }

    private void InitCanvas() {
        // Debug.Log("Init Canvas");
        Vid4.SetActive(true);
        Vid5.SetActive(false);
        Purse.SetActive(false);
        UsePurse.SetActive(false);
        OS.SetActive(false);
        PayImage.SetActive(false);
    }

    private void ShowPurse() {
        Purse.SetActive(true);
        UsePurse.SetActive(true);
    }

    private void AfterVid5Active() {
        OS.SetActive(true);
        // phoneManager.ActivateVid7();
    }

    private void UsePurse2() {
        CanvasUsePurse2.SetActive(true);
        // gameManager.PlayVid8();
    }
    private void useButtonOnClick() {
        CanvasUsePurse2.SetActive(false);
        PayImage.SetActive(false);
        gameManager.PlayVid8();
    }
}