using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CleaningSheet : MonoBehaviour
{
    Scene2_GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<Scene2_GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        Debug.Log("CleaningSheet.OnMouseDown");
        gameManager.getCleaningSheet();
    }
}
