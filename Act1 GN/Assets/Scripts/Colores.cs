using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colores : MonoBehaviour
{

    public MeshRenderer meshRenderer;
    public Color color;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer.material.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
