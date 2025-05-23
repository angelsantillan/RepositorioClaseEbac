using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class script5 : MonoBehaviour
{
    public GameObject prefabCubo;
    public List<GameObject> listaDeCubos;
    public float factorDeEscalamiento;
    public int numCubos = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        listaDeCubos = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if(numCubos<10)
        {
            Color c = new Color(Random.value, Random.value, Random.value);
            numCubos++;
            GameObject tempGameObject = Instantiate<GameObject>(prefabCubo);
            tempGameObject.name = "CuboNumero" + numCubos;
            tempGameObject.transform.position = new Vector3(Random.value * 2, Random.value * 2, Random.value * 2);
            var meshRenderer = tempGameObject.GetComponent<MeshRenderer>().material;
            meshRenderer.color = c;
        }
        
    }
}
