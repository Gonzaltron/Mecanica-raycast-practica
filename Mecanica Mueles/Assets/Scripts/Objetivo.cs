using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.UIElements;
using static UnityEngine.GraphicsBuffer;

public class Objetivo : MonoBehaviour
{
    [SerializeField] GameObject objetivo;
    bool yes;
    [SerializeField] float torque;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        yes = false;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            yes = true;
        }
        if(yes)
        {
            transform.LookAt(objetivo.transform.position);
            rb.AddTorque(transform.forward * torque, ForceMode.Force);
        }
    }
}
