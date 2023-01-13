using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PhoneManager : MonoBehaviour
{
    public GameObject Canvas_Vid1_phone, Canvas_Vid2_phone, Canvas_NoVidPhone;
    public GameObject Canvas_Vid1, Canvas_Vid2;

    [Header("Canvas Vid1 X button")]
    public Button Canvas_Vid1_X;
    [Header("Phone-Icon from Canvas Vid 1 Phone")]
    public Button Canvas_Vid1_phone_Icon;
    [Header("Phone-Icon from Canvas Vid 2 Phone")]
    public Button Canvas_Vid2_phone_Icon;
    [Header("Back To Dorm Button from Canvas Vid 2")]
    public Button Canvas_Vid2_BackToDorm;
    [Header("message")] public GameObject messageSound;

    // public Button PhoneIcon_Vid1, PhoneIcon_Vid2;
    // public Button Canvas_Vid1_X, Canvas_Vid2_BackToDorm;

    // Start is called before the first frame update
    void Start()
    {
        messageSound.SetActive(true);
        Invoke(nameof(DisableSound), 3f);
        // Get Canvas_Vid1_phone_Icon
        Canvas_Vid1_phone_Icon.GetComponent<Button>().onClick.AddListener(() => {
            Canvas_Vid1.SetActive(true);
            phoneStage(3); // NoVidPhone
        });
        // Get Canvas_Vid2_phone_Icon
        Canvas_Vid2_phone_Icon.GetComponent<Button>().onClick.AddListener(() => {
            Canvas_Vid2.SetActive(true);
            Invoke(nameof(activatebtn), 20f);
        });

        // Get Canvas_Vid1_X
        Canvas_Vid1_X.GetComponent<Button>().onClick.AddListener(() => {
            Canvas_Vid1.SetActive(false);
        });

        // Buttons actions
        Canvas_Vid2_BackToDorm.GetComponent<Button>().onClick.AddListener(() => {
            SceneManager.LoadScene("Scene3");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void phoneStage(int x) {
        Canvas_Vid1_phone.SetActive(false);
        Canvas_Vid2_phone.SetActive(false);
        Canvas_NoVidPhone.SetActive(false);
        switch (x) {
            case 1: 
                Canvas_Vid1_phone.SetActive(true);
                messageSound.SetActive(true);
                break;
            case 2: 
                Canvas_Vid2_phone.SetActive(true);
                messageSound.SetActive(true);
                break;
            case 3: 
                Canvas_NoVidPhone.SetActive(true);
                break;
            default:
                break;
        }
        Invoke(nameof(DisableSound), 3f);
    }
    private void activatebtn() {
        Canvas_Vid2_BackToDorm.gameObject.SetActive(true);
    }
    private void DisableSound() {
        Debug.Log("Sound");
        messageSound.SetActive(false);
    }
}
