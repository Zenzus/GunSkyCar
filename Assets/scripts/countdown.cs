﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class countdown : MonoBehaviour
{

    [SerializeField] private Text uiText;
    [SerializeField] private float mainTimer;

    private bool hasCollide = false;
    private float timer;
    private bool canCount = true;
    private bool doOnce = false;
    // Start is called before the first frame update
    void Start()
    {
        timer = mainTimer;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= 0.0f && canCount)
        {
            timer -= Time.deltaTime;
            uiText.text = timer.ToString("F");
        }
        else if (timer <= 0.0f && !doOnce)
        {
            canCount = false;
            doOnce = true;
            uiText.text = "0.00";
            timer = 0.0f;
            GameOver();
        }
    }
   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            if (hasCollide == false) 
            {
                timer += 10;
               
            }
        }
    }


    void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
