﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseScreenCanvas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    public void Open()
    {
        gameObject.SetActive(true);
    }
}
