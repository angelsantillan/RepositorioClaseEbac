using UnityEngine;

public class script1 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool colorActivo = true;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void Awake()
    {
        
    }
    private void FixedUpdate()
    {
        colorActivo = !colorActivo;
        GameObject myGameObject = gameObject;
        var meshRenderer = myGameObject.GetComponent<MeshRenderer>().material;
        if (colorActivo)
            meshRenderer.color = Color.white;
        else meshRenderer.color = Color.black;
    }
}

