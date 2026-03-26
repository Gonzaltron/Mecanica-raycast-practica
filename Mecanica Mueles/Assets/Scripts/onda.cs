using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

public class onda : MonoBehaviour
{
    float initT;
    float initPos;
    [SerializeField] float amplitude;
    [SerializeField] float anchura;
    [SerializeField] float strength;
    float pos;
    float pos1;
    float pos2;
    LineRenderer lineRenderer;
    int points = 100;
    float e = 2.71828f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = points;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            pos += strength;
            initPos = pos;
            initT = Time.time;
            for (int i = 0; i < points; i++)
            {
                float x = initPos + (i * amplitude);
                pos1 += Mathf.Pow(e, pos1 - initPos/ anchura * 2);
                pos2 -= Mathf.Pow(e, pos1 - initPos/ anchura * 2);
                lineRenderer.SetPosition(i, new Vector3(x, pos1, 0));
                lineRenderer.SetPosition(i, new Vector3(-x, pos2, 0));
            }
        }
    }
}
