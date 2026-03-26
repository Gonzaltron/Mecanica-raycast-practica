using UnityEngine;

public class sin : MonoBehaviour
{
    [SerializeField] float amplitude;
    LineRenderer linerenderer;
    int points = 100;
    [SerializeField] float length = 100.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        linerenderer = GetComponent<LineRenderer>();
        linerenderer.positionCount = points;
    }

    // Update is called once per frame
    void Update()
    {
        float startX = -length * 0.5f;
        float step = length / (points-1);
        for(int i = 0; i < points; i++)
        {
            float x = startX + i * step;
            float y = amplitude * Mathf.Cos(x + Time.time);
            linerenderer.SetPosition(i, new Vector3(x, y, 0));
        }
    }
}
