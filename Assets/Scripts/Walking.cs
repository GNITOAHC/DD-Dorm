using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
    public GameObject player;
    private int movespeed = 3;
    private float rotatespeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move();
        if (Input.GetKey(KeyCode.UpArrow)){
            // update 60 fps -> 1s 60frame, 1/60 s, 1/60 * 60 = 1, (1, 0.1, 0)
            player.transform.position += player.transform.forward * Time.deltaTime * movespeed;
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            player.transform.position -= player.transform.forward * Time.deltaTime * movespeed;
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            player.transform.position += player.transform.right * Time.deltaTime * movespeed;
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            player.transform.position -= player.transform.right * Time.deltaTime * movespeed;
        }
        if (Input.GetKey(KeyCode.J)) {
            player.transform.Rotate(new Vector3(0, -rotatespeed, 0));
        }
        if (Input.GetKey(KeyCode.K)) {
            player.transform.Rotate(new Vector3(0, rotatespeed, 0));
        }
    }
}
