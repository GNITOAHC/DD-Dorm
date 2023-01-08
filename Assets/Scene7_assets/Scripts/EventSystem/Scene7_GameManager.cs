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
    [Header("DormMusic")] public GameObject DormMusic;
    // Start is called before the first frame update
    void Start()
    {
        DormMusic.SetActive(false);
        Canvas_Vid13.SetActive(true);
        Invoke(nameof(RestartCanvas), 60f); // 60f
        restart.onClick.AddListener(() => SceneManager.LoadScene("Scene0"));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void RestartCanvas() {
        DormMusic.SetActive(true);
        Canvas_Vid13.SetActive(false);
        Canvas_GameOver.SetActive(true);
    }
}
