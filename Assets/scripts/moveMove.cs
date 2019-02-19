using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveMove : MonoBehaviour
{
    float x;
    float y;
    float z;

    void Start()
    {
        
        z = transform.position.z;
        x = transform.position.x;
        y = transform.position.y;
        StartCoroutine(movement());

    }
  
    IEnumerator movement()
    {
        while (true)
        {  
            transform.DOMove(new Vector3(x + 70, y, z), 2);
            yield return new WaitForSeconds(3f);
            transform.DOMove(new Vector3(x - 70, y, z), 2);
            yield return new WaitForSeconds(2f);
            transform.DOMove(new Vector3(x , y+30, z), 2);
            yield return new WaitForSeconds(1f);
            transform.DOMove(new Vector3(x, y -30, z), 2);
        }
    }
}