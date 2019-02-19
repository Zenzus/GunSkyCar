using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour
{


    public float upSpeed = 10f;
    public float aroundSpeed = 2f;



    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Rotate(Vector3.up, upSpeed * Time.deltaTime);
        transform.RotateAround(Vector3.up, aroundSpeed * Time.deltaTime);
    }
}
