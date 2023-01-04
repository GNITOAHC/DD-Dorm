using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class ToggleBackpack : MonoBehaviour
{
    public Button backpackIcon;
    public Button X;
    public GameObject Backpack;
    private bool isOpen;

    // Start is called before the first frame update
    void Start()
    {
        Button btn_BackpackIcon = backpackIcon.GetComponent<Button>();
		btn_BackpackIcon.onClick.AddListener(OpenUI);

        Button btn_X = X.GetComponent<Button>();
		btn_X.onClick.AddListener(CloseUI);

        isOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Toggle() {
        Debug.Log("Toggle");
        Backpack.SetActive(!isOpen);
        // Backpack.SetActive(!isOpen);
        isOpen = !isOpen;
    }
    private void OpenUI() {
        Debug.Log("Toggle OpenUI");
        Backpack.SetActive(true);
    }
    private void CloseUI() {
        Debug.Log("Toggle CloseUI");
        Backpack.SetActive(false);
    }
}
