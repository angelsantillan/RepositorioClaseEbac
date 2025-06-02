using UnityEngine;

public class script2 : MonoBehaviour
{
    public bool colorActivo = true;
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
        colorActivo = !colorActivo;
        GameObject myGameObject = gameObject;
        var meshRenderer = myGameObject.GetComponent<MeshRenderer>().material;
        if (colorActivo)
            meshRenderer.color = Color.white;
        else meshRenderer.color = Color.black;
    }
}
