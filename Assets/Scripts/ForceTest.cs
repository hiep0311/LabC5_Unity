using UnityEngine;

public class ForceTest : MonoBehaviour
{
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            rb.AddForce(Vector3.forward * 300);
        }
    }
}
