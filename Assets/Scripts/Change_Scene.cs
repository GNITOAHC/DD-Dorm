using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Change_Scene : MonoBehaviour
{
    public Button change;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = change.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TaskOnClick() {
        SceneManager.LoadScene("SampleScene");
    }
}
