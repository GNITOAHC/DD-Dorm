using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene3_BackpackManager : MonoBehaviour
{
    public GameObject Backpack_LieTest, Backpack_Wallet;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void backpackStage(int x) {
        switch (x) {
            case 1:
                Backpack_LieTest.SetActive(true);
                Backpack_Wallet.SetActive(false);
                break;
            case 2: 
                Backpack_LieTest.SetActive(false);
                Backpack_Wallet.SetActive(true);
                break;
            default: break;
        }
    }
}
