using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene5_GameManager : MonoBehaviour
{
    [Header("Canvas-OpeningAnimation")] public GameObject OpeningAnimation;
    private bool canreceipt = false, alreadyreceipt = false;
    // Start is called before the first frame update
    void Start()
    {
        OpeningAnimation.SetActive(true);
        Invoke(nameof(closeOpening), 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void closeOpening() {
        OpeningAnimation.SetActive(false);
    }
    public bool canReceipt() {
        // Debug.Log(canreceipt ? "canreceipt" : "noreceipt");
        return canreceipt;
    }
    public void alreadyReport() {
        // Debug.Log("canreceipt = true");
        canreceipt = true;
    }
    public void alreadyReceipt() {
        alreadyreceipt = true;
    }
    public bool getAlreadyReceipt() {
        return alreadyreceipt;
    }
}
