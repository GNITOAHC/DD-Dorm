using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Scene4_PhoneManager : MonoBehaviour
{
    [Header("Canvas-Vid7_Phone")] public GameObject Vid7Phone;
    [Header("Canvas-NoVidPhone")] public GameObject NoVidPhone;
    [Header("Canvas-Vid7")] public GameObject Canvas_Vid7;
    [Header("Phone Icon from Canvas-Vid7_Phone")] public GameObject Vid7PhoneIcon;
    [Header("X Button from Canvas-Vid7")] public GameObject XButton;
    // Start is called before the first frame update
    void Start()
    {
        Vid7Phone.SetActive(false); // Initialized
        NoVidPhone.SetActive(false); // Initialized

        Vid7PhoneIcon.GetComponent<Button>().onClick.AddListener(() => Canvas_Vid7.SetActive(true));
        XButton.GetComponent<Button>().onClick.AddListener(XonClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateVid7() {
        Debug.Log("Activating Vid 7");
        Vid7Phone.SetActive(true);
    }

    private void XonClick() {
        Canvas_Vid7.SetActive(false);
        Vid7Phone.SetActive(false);
        NoVidPhone.SetActive(true);
    }
}
