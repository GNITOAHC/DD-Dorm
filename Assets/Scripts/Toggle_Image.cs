using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Toggle_Image : MonoBehaviour
{
    public Button toggle;
    public GameObject image;
    private bool isOpen;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = toggle.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);

        isOpen = false;
        // Init isOpen to false
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick() {
		// Debug.Log ("You have clicked the button!");
        image.SetActive(!isOpen);
        isOpen = !isOpen;
        //image.SetActive(false);
	}
}
