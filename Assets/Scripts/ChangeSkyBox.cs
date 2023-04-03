using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ChangeSkyBox : MonoBehaviour
{
    // skybox
    public Material[] skyMats;
    float timer = 0f; 
    int index = 0;

    void Awake()
    {
        RenderSettings.skybox = skyMats[index];
    }
    
    private void Start()
    {       

    }

    void Update()
    {
        timer += Time.deltaTime; // seconds
        if (timer >= 5)
        {
            index += 1;
            if (index > 9) {index -= 10;}
            RenderSettings.skybox = skyMats[index];
            timer = 0f;
        }
    }
}