using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputSpace : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        CreateCubeAndSetParent();
    }

    private void CreateCubeAndSetParent()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.SetParent(this.transform);
    }

    // Update is called once per frame
    void Update()
    {
        checkMovement();
        checkScale();
        checkRotation();
    }
    private void checkMovement()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log(gameObject.transform.position);
            Debug.Log("Position X: " + this.transform.position.x);
            Debug.Log("Position Y: " + this.transform.position.y);
            Debug.Log("Position Z: " + this.transform.position.z);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.transform.position += Vector3.up * speed;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.transform.position += Vector3.down * speed;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.transform.position += Vector3.left * speed;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.transform.position += Vector3.right * speed;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            this.transform.position += Vector3.forward * speed;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            this.transform.position += Vector3.back * speed;
        }
    }

    private void checkScale()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            this.transform.localScale += Vector3.up;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            this.transform.localScale += Vector3.down;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            this.transform.localScale += Vector3.left;
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            this.transform.localScale += Vector3.right;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            this.transform.localScale += Vector3.forward;
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            this.transform.localScale += Vector3.back;
        }
    }

    private void checkRotation()
    {
       this.transform.localRotation *= Quaternion.Euler(0, 1 * speed, 0);    
    }

}
