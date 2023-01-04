using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Elephant : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Canvas_OS;
    [Header("Spotlight for elephant")]
    public GameObject Elephant_light;
    [Header("Spotlight for Headphones")]
    public GameObject Headphones_light;
    // TogglePhone funcPhone;
    Scene1_GameManager funcPhoneCanToggle;
    void Start()
    {
        funcPhoneCanToggle = FindObjectOfType<Scene1_GameManager>(); // Find Object

        // Find X btn
        Transform obj = Canvas_OS.GetComponent<Transform>().Find("X-Button");
        Button X = obj.GetComponent<Button>();

        // Get X btn
		X.GetComponent<Button>().onClick.AddListener(changeLight);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void changeLight() {
        Canvas_OS.SetActive(false);
        Headphones_light.SetActive(true);
        Elephant_light.SetActive(false);
    }

    private void OnMouseDown() {
        Canvas_OS.SetActive(true);
        // Enable Phone
        funcPhoneCanToggle.EnableToggle();
    }
}
