using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Transform tr;
    public float moveSpeed = 5f;
    public float rotateSpeed = 3000f;

    void Start()
    {
        tr = GetComponent<Transform>();
    }

    void Update()
    {
        float adValue = Input.GetAxis("Horizontal");
        float wsValue = Input.GetAxis("Vertical");
        float mValue = Input.GetAxis("Mouse X");

        var moveDirection = (Vector3.forward * wsValue) + (Vector3.right * adValue);
        tr.Translate(moveDirection.normalized * moveSpeed * Time.deltaTime, Space.Self);
        tr.Rotate(Vector3.up * rotateSpeed * Time.deltaTime * mValue);
    }
}