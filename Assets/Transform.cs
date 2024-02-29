using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LogPosition();

    }

    private void LogPosition()
    {
        Debug.Log(gameObject.transform.position);
        Debug.Log(gameObject.transform.rotation);
        Debug.Log(gameObject.transform.localPosition);
    }
}
