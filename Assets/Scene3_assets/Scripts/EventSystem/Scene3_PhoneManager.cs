using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Scene3_PhoneManager : MonoBehaviour
{
    [Header("Canvas-vid3")] public GameObject Canvas_vid3;
    [Header("PhoneIcon from Canvas-vid3_phone")] public Button PhoneIcon_Vid3;
    [Header("Canvas-vid3_phone")] public GameObject Vid3_phone;
    [Header("Canvas-NoVid_phone")] public GameObject NoVidPhone;
    [Header("X from Canvas-Vid3")] public Button Canvas_vid3_X;
    // Start is called before the first frame update
    void Start()
    {
        NoVidPhone.SetActive(false);
        Button vid3_btn = PhoneIcon_Vid3.GetComponent<Button>();
        vid3_btn.onClick.AddListener(OpenCanvasVid3);

        Button vid3_X = Canvas_vid3_X.GetComponent<Button>();
        vid3_X.onClick.AddListener(CloseVid3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void phoneStage(int x) {
        Vid3_phone.SetActive(false);
        // NoVidPhone.SetActive(false);
        switch (x) {
            case 3: 
                Debug.Log("Vid3_phone active");
                Vid3_phone.SetActive(true);
                break;
            case 0:
                NoVidPhone.SetActive(true);
                break;
            default: 
                break;
        }
    }

    public void OpenCanvasVid3() {
        Debug.Log("ToggleCanvasVid3");
        Canvas_vid3.SetActive(true);
    }
    public void CloseVid3() {
        Debug.Log("CloseVid3");
        Canvas_vid3.SetActive(false);
        phoneStage(0);
    }
}
