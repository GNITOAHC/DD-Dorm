using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Wallet : MonoBehaviour
{
    public GameObject Canvas_Wallet;
    public GameObject GetProp, NextScene;
    // Start is called before the first frame update
    void Start()
    {
        NextScene.SetActive(false);

        Button getPropBtn = GetProp.GetComponent<Button>();
        getPropBtn.onClick.AddListener(() => NextScene.SetActive(true));

        Button nextSceneBtn = NextScene.GetComponent<Button>();
        nextSceneBtn.onClick.AddListener(() => {SceneManager.LoadScene("Scene4");});
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown() {
        Canvas_Wallet.SetActive(true);
    }
}
