using UnityEngine;

public class Medidor : MonoBehaviour
{
    public RaycastHit hit;
    public float distance;
    public float mindistance;
    Vector3 down;
    public Vector3 impacto;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        down = transform.TransformDirection(Vector3.down);
    }

    // Update is called once per frame
    void Update()
    {
        Physics.Raycast(transform.position, down, out hit, mindistance);
        impacto = hit.point;
    }
}
