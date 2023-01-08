using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene7_GameManager : MonoBehaviour
{
    [Header("Canvas-Vid13&End")] public GameObject Canvas_Vid13;
    [Header("Canvas-GameOver")] public GameObject Canvas_GameOver;
    [Header("Button-Restart from Canvas-GameOver")] public Button restart;
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(Vid13), 5f);
        restart.onClick.AddListener(() => SceneManager.LoadScene("Scene0"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Vid13() {
        Canvas_Vid13.SetActive(true);
        Invoke(nameof(RestartCanvas), 60f); // 60f
    }
    private void RestartCanvas() {
        Canvas_Vid13.SetActive(false);
        Canvas_GameOver.SetActive(true);
    }
}
