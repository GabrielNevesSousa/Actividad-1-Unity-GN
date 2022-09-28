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

        //1 Metro derecha
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

        if (Input.GetKey(KeyCode.V))
        {
            objetos[3].position += Vector3.right;
        }

        if (Input.GetKey(KeyCode.B))
        {
            objetos[4].position += Vector3.right;
        }

        //1 Metro izquierda

        if (Input.GetKey(KeyCode.Q))
        {
            objetos[0].position += Vector3.left;
        }

        if (Input.GetKey(KeyCode.W))
        {
            objetos[1].position += Vector3.left;
        }

        if (Input.GetKey(KeyCode.E))
        {
            objetos[2].position += Vector3.left;
        }

        if (Input.GetKey(KeyCode.R))
        {
            objetos[3].position += Vector3.left;
        }

        if (Input.GetKey(KeyCode.T))
        {
            objetos[4].position += Vector3.left;
        }

        //1 Metro hacia arriba

        if (Input.GetKey(KeyCode.A))
        {
            objetos[0].position += Vector3.up;
        }

        if (Input.GetKey(KeyCode.S))
        {
            objetos[1].position += Vector3.up;
        }

        if (Input.GetKey(KeyCode.D))
        {
            objetos[2].position += Vector3.up;
        }

        if (Input.GetKey(KeyCode.F))
        {
            objetos[3].position += Vector3.up;
        }

        if (Input.GetKey(KeyCode.G))
        {
            objetos[4].position += Vector3.up;
        }


        //Barra de espacio todos los elementos a la posición 0
        if (Input.GetKey(KeyCode.Space))
        {
            foreach (Transform obj in objetos)
            {
                obj.transform.position = new Vector3(0, 0, 0);
            }
        }

        //Esfera1 si supera los limites vuelve a la posición 0
        if (objetos[3].position.x >  4 || objetos[3].position.x < -4 || objetos[3].position.y > 4 || objetos[3].position.y < -4)
        {
            objetos[3].transform.position = new Vector3(0, 0, 0);
        }

        //Esfera2 si supera los limites vuelve a la posición 0

        if (objetos[4].position.x > 4 || objetos[4].position.x < -4 || objetos[4].position.y > 4 || objetos[4].position.y < -4)
        {
            objetos[4].transform.position = new Vector3(0, 0, 0);
        }
    }



}