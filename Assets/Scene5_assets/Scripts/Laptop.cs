using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Laptop : MonoBehaviour
{
    [Header("Canvas-Vid11")] public GameObject CanvasVid11;
    [Header("Canvas-Vid12")] public GameObject CanvasVid12;
    [Header("Canvas-Backpack-UseAll")] public GameObject UseAll;
    private Scene5_GameManager GameManager;
    // Start is called before the first frame update
    void Start()
    {
        GameManager = FindObjectOfType<Scene5_GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        if (!GameManager.getAlreadyReceipt()) return;
        // Else
        // Debug.Log("Laptop is already");
        CanvasVid11.SetActive(true);
        Invoke(nameof(BackPackUseAll), 40f); // 40f
    }
    private void BackPackUseAll() {
        UseAll.SetActive(true);
    }
    public void Vid12Activate() {
        CanvasVid11.SetActive(false);
        UseAll.SetActive(false);
        CanvasVid12.SetActive(true);
        Invoke(nameof(NextScene), 32f); //32f
    }
    private void NextScene() {
        SceneManager.LoadScene("Scene6");
    }
}
