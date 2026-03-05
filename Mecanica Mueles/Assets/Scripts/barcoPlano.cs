using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class barcoPlano : MonoBehaviour
{
    List <Medidor> child = new List<Medidor>();
    [SerializeField] float minDistance;
    Vector3 uno;
    Vector3 dos;
    Vector3 normal;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        child.Add(GetComponentInChildren<Medidor>());
        foreach (Medidor item in child)
        {
            item.mindistance = minDistance;
        }
    }

    // Update is called once per frame
    void Update()
    {
        uno = new Vector3(child[2].impacto.x - child[1].impacto.x, child[2].impacto.y - child[1].impacto.y, child[2].impacto.z - child[1].impacto.z);
        uno = new Vector3(child[2].impacto.x - child[3].impacto.x, child[2].impacto.y - child[3].impacto.y, child[2].impacto.z - child[3].impacto.z);
        Vector3.Normalize(uno);
        Vector3.Normalize(dos);
        normal = new Vector3(Mathf.Sqrt(uno.x * uno.x + dos.x * dos.x), Mathf.Sqrt(uno.y * uno.y + dos.y * dos.y), Mathf.Sqrt(uno.z * uno.z + dos.z * dos.z));
        rb.AddTorque(normal * torque, ForceMode Force);
    }
}
