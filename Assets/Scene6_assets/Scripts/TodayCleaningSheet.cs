using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class TodayCleaningSheet : MonoBehaviour
{
    [Header("Canvas-TodayCleaningSheet")] public GameObject CanvasTodayCleaningSheet;
    [Header("X button from Canvas")] public Button X;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        X.onClick.AddListener(() => CanvasTodayCleaningSheet.SetActive(false));
    }
    private void OnMouseDown() {
        CanvasTodayCleaningSheet.SetActive(true);
    }
}
