using UnityEngine;

public class GreedDeCubos : MonoBehaviour
{
    [SerializeField] int lados;
    [SerializeField] GameObject cubos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i = 0; i<= lados; i++)
        {
            for (int j = 0; j<= lados; j++)
            {
                GameObject.Instantiate(cubos, new Vector3(i, 0, j), Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
