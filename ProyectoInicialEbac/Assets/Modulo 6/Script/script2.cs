using UnityEngine;

public class script2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Color c = new Color(Random.value, Random.value, Random.value);
        GameObject myGameObject = gameObject;
        var meshRenderer = myGameObject.GetComponent<MeshRenderer>().material;
        meshRenderer.color = c;
    }
}
