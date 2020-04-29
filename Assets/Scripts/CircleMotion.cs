using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMotion : MonoBehaviour
{
    [Tooltip("speed rotation")] [SerializeField] private float RotateSpeed = 5f;
    private float Radius = 1f;
    private bool isRight = true;
    private Vector2 _centre;
    private float _angle;

    private void Start()
    {
        _centre = transform.position;
    }

    private void Update()
    {

        _angle += RotateSpeed * Time.deltaTime;


        if (Input.GetKey("right") && !isRight)
        {
            RotateSpeed *= -1;
            isRight = !isRight;
        }
        else if (Input.GetKey("left") && isRight)
        {
            RotateSpeed *= -1;
            isRight = !isRight;
        }
        var offset = new Vector2(Mathf.Sin(_angle), Mathf.Cos(_angle)) * Radius;
        transform.position = _centre + offset;
    }

}
