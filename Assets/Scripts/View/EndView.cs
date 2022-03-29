﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndView : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(BackToHome);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void BackToHome()
    {
        SceneManager.LoadScene(0);
    }
}
