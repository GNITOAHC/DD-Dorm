using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Notepaper : MonoBehaviour
{
    [Header("Canvas-Notepaper")] public GameObject CanvasNotepaper;
    private Image OS;
    // Start is called before the first frame update
    void Start()
    {
        OS = CanvasNotepaper.transform.GetChild(2).GetComponent<Image>();
        OS.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        CanvasNotepaper.SetActive(true);
        Invoke(nameof(ShowOS), 5f);
    }
    private void ShowOS() {
        OS.gameObject.SetActive(true);
        Invoke(nameof(NextScene), 5f);
    }
    private void NextScene() {
        SceneManager.LoadScene("Scene7");
    }
}
