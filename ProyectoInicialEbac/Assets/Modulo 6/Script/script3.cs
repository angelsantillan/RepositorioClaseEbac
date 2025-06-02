using JetBrains.Annotations;
using UnityEngine;

public class script3 : MonoBehaviour
{
    public bool colorActivo;
    private bool colorActivo1;
    private bool colorActivo2;   
    public GameObject objeto1;
    public GameObject objeto2;
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
        if(objeto1 != null) colorActivo1=objeto1.GetComponent<script1>().colorActivo;
        if (objeto2 != null) colorActivo2 = objeto2.GetComponent<script2>().colorActivo;
        colorActivo = colorActivo1 && colorActivo2;
        if (colorActivo)
        meshRenderer.color = Color.white;
        else meshRenderer.color = Color.black;
    }
}
