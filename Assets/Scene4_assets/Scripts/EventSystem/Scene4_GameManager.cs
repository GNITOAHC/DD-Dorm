using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene4_GameManager : MonoBehaviour
{
    private bool OrderMachineAlready = false;
    private bool AtmAlready = false;
    [Header("Canvas-Vid8")] public GameObject CanvasVid8;
    [Header("FindBB from Canvas-Vid8")] public GameObject FindBB;
    [Header("Canvas-Vid9")] public GameObject CanvasVid9;
    [Header("Canvas-CheckoutClue")] public GameObject CanvasCheckoutClue;
    [Header("Canvas-Notebook")] public GameObject CanvasNotebook;
    [Header("Canvas-Vid10")] public GameObject CanvasVid10;
    [Header("Canvas-LastOS")] public GameObject CanvasLastOS;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FindBB.GetComponent<Button>().onClick.AddListener(FindBBFunction);
    }
    public bool getOrderMachineAlready() { return OrderMachineAlready; }
    public void setOrderMachineAlready(bool o) { OrderMachineAlready = o; }
    public bool getAtmAlready () { return AtmAlready; }
    public void setAtmAlready(bool o) { AtmAlready = o; }

    public void PlayVid8() {
        CanvasVid8.SetActive(true);
    }
    private void FindBBFunction() {
        CanvasVid8.SetActive(false);
        CanvasVid9.SetActive(true);
        Invoke(nameof(CheckoutClue), 18f); // 18f
    }
    private void CheckoutClue() {
        CanvasCheckoutClue.SetActive(true);
        Button check = CanvasCheckoutClue.transform.GetChild(0).GetComponent<Button>();
        check.onClick.AddListener(() => {
            CanvasVid9.SetActive(false);
            CanvasNotebook.SetActive(true);
            CanvasCheckoutClue.SetActive(false);
            CanvasNotebookActive();
        });
    }
    private void CanvasNotebookActive() {
        Image Notebook = CanvasNotebook.transform.GetChild(1).GetComponent<Image>();
        Image NotebookName = CanvasNotebook.transform.GetChild(2).GetComponent<Image>();
        Button Next = CanvasNotebook.transform.GetChild(3).GetComponent<Button>();
        Image Report = CanvasNotebook.transform.GetChild(4).GetComponent<Image>();
        Button btn_x = CanvasNotebook.transform.GetChild(5).GetComponent<Button>();

        // Report.enabled = false;
        Report.gameObject.SetActive(false);
        btn_x.gameObject.SetActive(false);
        Next.onClick.AddListener(() => {
            Notebook.gameObject.SetActive(false);
            NotebookName.gameObject.SetActive(false);
            Report.gameObject.SetActive(true);
            Next.gameObject.SetActive(false);
            btn_x.gameObject.SetActive(true);
        });
        btn_x.onClick.AddListener(() => {
            CanvasNotebook.SetActive(false);
            CanvasVid10.SetActive(true);
            CanvasVid10Active();
        });
    }
    private void CanvasVid10Active() {
        Debug.Log("CanvasVid10Active");
        CanvasVid10.SetActive(true);
        Invoke(nameof(JumpLastOS), 10f);
    }
    private void JumpLastOS() {
        Debug.Log("JumpLastOS");
        CanvasLastOS.SetActive(true);
        Button NextScene = CanvasLastOS.transform.GetChild(2).GetComponent<Button>();
        NextScene.onClick.AddListener(() => SceneManager.LoadScene("Scene5"));
    }
}
