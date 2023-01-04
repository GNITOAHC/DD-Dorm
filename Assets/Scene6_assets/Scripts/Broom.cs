using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Broom : MonoBehaviour
{
    [Header("Canvas-Broom")] public GameObject CanvasBroom;
    [Header("Start from Canvas-Broom")] public Button btn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        btn.onClick.AddListener(() => {
            CanvasBroom.SetActive(false);
        });
    }
    private void OnMouseDown() {
        CanvasBroom.SetActive(true);
    }
}
