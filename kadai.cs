using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class kadai : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] points = { 0, 1, 2, 3, 4, 5 };

        for(int i = 0; i < points.Length; i++)
        {
            Debug.Log(points[i]);
        }

        int[] arr = { 0, 1, 2, 3, 4, 5 };

        for (int i = arr.Length - 1;i >= 0; i--)
        {
            Debug.Log(arr[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
