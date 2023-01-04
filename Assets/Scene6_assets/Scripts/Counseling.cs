using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Counseling : MonoBehaviour
{
    [Header("Canvas-Counseling")] public GameObject CanvasCounseling;
    [Header("X button from Counseling")] public Button XButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        XButton.onClick.AddListener(() => CanvasCounseling.SetActive(false));
    }
    private void OnMouseDown() {
        CanvasCounseling.SetActive(true);
    }
}
