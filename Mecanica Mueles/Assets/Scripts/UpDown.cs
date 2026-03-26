using UnityEngine;

public class UpDown : MonoBehaviour
{ 
    [SerializeField] float amplitude;
    [SerializeField] float vAngular = Mathf.PI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mov = amplitude * Mathf.Cos(vAngular * Time.time);
        this.transform.position = new Vector3(transform.position.x, mov, transform.position.z);
    }
}
