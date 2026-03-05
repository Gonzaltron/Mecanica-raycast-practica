using UnityEngine;

public class Muelle : MonoBehaviour
{
    Vector3 down;
    [SerializeField] float minDistance;
    [SerializeField] float maxDistance;
    [SerializeField] float drag;
    [SerializeField] float force;
    float distance;
    [SerializeField] float konstant;
    [SerializeField] float amortiguation;
    float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        down = transform.TransformDirection(Vector3.down);
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, down, minDistance))
        {
            distance = distance - maxDistance;
            force = -konstant*distance-amortiguation*speed;
            force -= drag;
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            rb.AddForce(0, force, 0);
            force = 0;
        }
    }
}
