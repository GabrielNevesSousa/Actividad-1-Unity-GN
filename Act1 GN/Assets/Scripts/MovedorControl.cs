using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovedorControl : MonoBehaviour
{

    public Transform[] objetos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            objetos[0].position += Vector3.right;
        }

        if (Input.GetKey(KeyCode.X))
        {
            objetos[1].position += Vector3.right;
        }

        if (Input.GetKey(KeyCode.C))
        {
            objetos[2].position += Vector3.right;
        }




    }
}