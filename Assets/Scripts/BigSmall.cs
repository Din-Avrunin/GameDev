using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class BigSmall : MonoBehaviour
{
    [Tooltip("size of ball")] [SerializeField] float size = 0.01f;
    // Start is called before the first frame update
    int isGrowing = 1;
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {

        if (transform.localScale.x > 10 && isGrowing > 0)
        {
            isGrowing *= -1;
        }
        else if (transform.localScale.x <= 1 && isGrowing < 0)
        {
            isGrowing *= -1;
        }
        Vector3 vec = transform.localScale;
        transform.localScale = new Vector3(vec.x + (isGrowing * size), vec.y + (isGrowing * size), 0);
        Debug.Log("transform.localScale.x is " + transform.localScale.x);

    }
}

