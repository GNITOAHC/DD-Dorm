using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Scene5_BackpackManager : MonoBehaviour
{
    [Header("Canvas-Backpack-Wallet")] public GameObject CanvasBackpackWallet;
    [Header("Canvas-Backpack-Report")] public GameObject CanvasBackpackReport;
    [Header("Canvas-Backpack-Receipt")] public GameObject CanvasBackpackReceipt;
    [Header("Canvas-Backpack-UseAll")] public GameObject CanvasBackpackUseAll;
    private Button use1, use2, use3, use4;
    private int useCount = 0;
    public Laptop LaptopVid12;
    // Start is called before the first frame update
    void Start()
    {
        Transform ButtonUse = CanvasBackpackUseAll.transform.GetChild(4);
        use1 = ButtonUse.GetChild(0).GetComponent<Button>();
        use2 = ButtonUse.GetChild(1).GetComponent<Button>();
        use3 = ButtonUse.GetChild(2).GetComponent<Button>();
        use4 = ButtonUse.GetChild(3).GetComponent<Button>();

        use1.onClick.AddListener(() => {
            ++useCount;
            use1.gameObject.SetActive(false);
        });
        use2.onClick.AddListener(() => {
            ++useCount;
            use2.gameObject.SetActive(false);
        });
        use3.onClick.AddListener(() => {
            ++useCount;
            use3.gameObject.SetActive(false);
        });
        use4.onClick.AddListener(() => {
            ++useCount;
            use4.gameObject.SetActive(false);
        });
    }

    // Update is called once per frame
    void Update()
    {
        if (useCount == 4) {
            // Debug.Log("Vid12");
            LaptopVid12.Vid12Activate();
        }
    }
    public void AddReport() {
        CanvasBackpackWallet.SetActive(false);
        CanvasBackpackReport.SetActive(true);
    }
    public void AddReceipt() {
        CanvasBackpackReport.SetActive(false);
        CanvasBackpackReceipt.SetActive(true);
    }
}
