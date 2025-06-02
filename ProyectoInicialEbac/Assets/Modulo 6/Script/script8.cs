using JetBrains.Annotations;
using UnityEngine;

public class script8 : MonoBehaviour
{
    private bool colorActivo3;
    private bool colorActivo4;
    public GameObject objeto3;
    public GameObject objeto4;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        GameObject myGameObject = gameObject;
        var meshRenderer = myGameObject.GetComponent<MeshRenderer>().material;
        if (objeto3 != null) colorActivo3 = objeto3.GetComponent<script3>().colorActivo;
        if (objeto4 != null) colorActivo4 = objeto4.GetComponent<script7>().colorActivo;

        if (colorActivo3 || colorActivo4)
            meshRenderer.color = Color.white;
        else meshRenderer.color = Color.black;
    }
}
