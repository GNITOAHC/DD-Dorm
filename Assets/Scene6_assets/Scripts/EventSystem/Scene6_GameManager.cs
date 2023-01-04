using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene6_GameManager : MonoBehaviour
{
    [Header("Canvas-OpeningAnimation")] public GameObject OpeningAnimation;
    // Start is called before the first frame update
    void Start()
    {
        OpeningAnimation.SetActive(true);
        Invoke(nameof(CloseOpening), 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void CloseOpening() {
        OpeningAnimation.SetActive(false);
    }
}
