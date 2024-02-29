using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionLogger : MonoBehaviour
{
    [SerializeField]
    private GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        //cube = GameObject.Find("Cube");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(cube.transform.localPosition);
    }
}
