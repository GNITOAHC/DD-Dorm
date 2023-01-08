using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene0_GameManager : MonoBehaviour
{
    [Header("Canvas-GameStart")] public GameObject CanvasGameStart;
    [Header("Button-Start from Canvas-GameStart")] public Button ButtonStart;
    [Header("Canvas-GameStartVid")] public GameObject CanvasGameStartVid;
    [Header("GameStartMusic")] public GameObject Music;
    // Start is called before the first frame update
    void Start()
    {
        ButtonStart.onClick.AddListener(() => {
            CanvasGameStart.SetActive(false);
            Music.SetActive(false);
            CanvasGameStartVid.SetActive(true);
            Invoke(nameof(NextScene), 45f); // 45f
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void NextScene() {
        SceneManager.LoadScene("Scene1");
    }
}
