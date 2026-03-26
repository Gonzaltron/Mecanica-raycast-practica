using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;
using static UnityEditor.PlayerSettings;

struct pulso
{
    public float initX;
    public float initY;
    public float initZ;
    public float amplitude;
    public float frequency;
    public float speed;
    public float initTime;
}

public class onda3D : MonoBehaviour
{
    [SerializeField] int lados;
    [SerializeField] GameObject cubos;
    [SerializeField] float amplitud;
    [SerializeField] float frequency;
    [SerializeField] float speed;
    List<GameObject> cubosL = new List<GameObject>();
    List<pulso> pulsoL = new List<pulso>();

    private void Start()
    {
        for (int i = 0; i <= lados; i++)
        {
            for (int j = 0; j <= lados; j++)
            {
                GameObject v = GameObject.Instantiate(cubos, new Vector3(i, 0, j), Quaternion.identity);
                cubosL.Add(v);
            }
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            NuevoPulso();
        }
        Pulso();
    }

    void NuevoPulso()
    {
        pulso p = new pulso
        {
            initX = Random.Range(0, 10),
            initY = 0,
            initZ = Random.Range(0, 10),
            amplitude = amplitud,
            frequency = frequency,
            speed = speed,
            initTime = Time.time
        };
        pulsoL.Add(p);
    }

    void Pulso()
    {
        foreach(GameObject obj in cubosL)
        {
            
            for (int i = 0;i < pulsoL.Count; i++)
            {
                pulso p = pulsoL[i];
                float x = p.initX + i;
                float age = Time.time - p.initTime;
                float distanciaR = age * speed;
                float dist = Mathf.Sqrt((p.initX - obj.transform.position.x * p.initX - obj.transform.position.x) * (p.initX - obj.transform.position.x * p.initX - obj.transform.position.x) + (p.initZ - obj.transform.position.z * p.initZ - obj.transform.position.z) * (p.initZ - obj.transform.position.z * p.initZ - obj.transform.position.z));
                float gaussian = Mathf.Exp(-(dist * dist) / (2f * amplitud * amplitud));
                float y = amplitud * gaussian;
                Debug.Log(gaussian);
                obj.transform.position = new Vector3(obj.transform.position.x, y, obj.transform.position.z);
            }
        }
    }
}
