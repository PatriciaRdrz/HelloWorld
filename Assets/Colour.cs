using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Colour : MonoBehaviour
{
    
    public GameObject sphere;
    // Start is called before the first frame update
    void Start()
    {
        //this.GetComponent<MeshRenderer>().material.color = Color.blue;

        var sphereRenderer = sphere.GetComponent<Renderer>();
        sphereRenderer.material.SetColor("_Color", Color.blue);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
