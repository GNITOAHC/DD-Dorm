using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Documents : MonoBehaviour
{
    [Header("Canvas-HealthReportOS")] public GameObject CanvasHealthReport;
    [Header("Canvas-ReceiptOS")] public GameObject CanvasReceipt;
    private Image HealthReportIMG, HealthReportOS, ReceiptIMG, ReceiptOS;
    private Button HealthReportGetItem, ReceiptGetItem;
    private Scene5_BackpackManager BackpackManager;
    private Scene5_GameManager GameManager;
    private int MouseDownStatus = 0;
    // Start is called before the first frame update
    void Start()
    {
        BackpackManager = FindObjectOfType<Scene5_BackpackManager>();
        GameManager = FindObjectOfType<Scene5_GameManager>();

        // CanvasHealthReport
        HealthReportIMG = CanvasHealthReport.transform.GetChild(1).GetComponent<Image>();
        HealthReportOS = CanvasHealthReport.transform.GetChild(2).GetComponent<Image>();
        HealthReportGetItem = CanvasHealthReport.transform.GetChild(3).GetComponent<Button>();

        // CanvasReceiptOS
        ReceiptIMG = CanvasReceipt.transform.GetChild(1).GetComponent<Image>();
        ReceiptOS = CanvasReceipt.transform.GetChild(2).GetComponent<Image>();
        ReceiptGetItem = CanvasReceipt.transform.GetChild(3).GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        if (GameManager.canReceipt()) {
            GameManager.alreadyReceipt();
            MouseDownStatus = 1;
            CanvasReceipt.SetActive(true);
            ReceiptOS.gameObject.SetActive(false);
            ReceiptGetItem.gameObject.SetActive(false);

            this.Invoke(nameof(StartOS), 2f);

            ReceiptGetItem.onClick.AddListener(() => {
                Debug.Log("ReceiptGetItem Toggle");
                CanvasReceipt.SetActive(false);
                BackpackManager.AddReceipt();
            });
        } else {
            GameManager.alreadyReport();
            CanvasHealthReport.SetActive(true);
            HealthReportOS.gameObject.SetActive(false);
            HealthReportGetItem.gameObject.SetActive(false);

            this.Invoke(nameof(StartOS), 2f);

            HealthReportGetItem.onClick.AddListener(() => {
                Debug.Log("HealthReportGetItem Toggled");
                CanvasHealthReport.SetActive(false);
                BackpackManager.AddReport();
            });
        }

        
    }
    private void StartOS() {
        if (MouseDownStatus == 0) {
            HealthReportOS.gameObject.SetActive(true);
            HealthReportGetItem.gameObject.SetActive(true);
        } else {
            ReceiptOS.gameObject.SetActive(true);
            ReceiptGetItem.gameObject.SetActive(true);
        }
    }
}
