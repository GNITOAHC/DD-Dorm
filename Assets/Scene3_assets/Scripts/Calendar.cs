using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Calendar : MonoBehaviour
{
    public GameObject Canvas_Calendar;
    public Button X;
    // Start is called before the first frame update
    void Start()
    {
        Button x = X.GetComponent<Button>();
        x.onClick.AddListener(CloseUI);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        Canvas_Calendar.SetActive(true);
    }
    private void CloseUI() {
        Canvas_Calendar.SetActive(false);
    }
}
