using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCount : MonoBehaviour
{

    public int points;
    // Start is called before the first frame update
    void Start()
    {
        points = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            points++;

        }
    }


        private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "Score : " + points);
    }
}
