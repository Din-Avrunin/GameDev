using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [SerializeField] float accX, accY, speedX, speedY;

    [Tooltip("positions of x y")] [SerializeField] float x = 0, y = 0;



    Vector3 v = new Vector3(0, 1, 3);
    // Start is called before the first frame update
    void Start()
    {

        /* an example for good values:
        accX = 0.00001f;
        accY = 0.00001f;
        speedX = 0.010f;
        speedY = 0.007f;
        */
        transform.position = new Vector3(x, y, -2);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= x && speedX > 0 && accX >= 0) { accX *= -1; }
        if (transform.position.x <= x && speedX < 0 && accX <= 0) { accX *= -1; }
        if (transform.position.y >= y && speedY > 0 && accY >= 0) { accY *= -1; }
        if (transform.position.y <= y && speedY < 0 && accY <= 0) { accY *= -1; }

        speedX += accX;
        speedY += accY;

        transform.position = new Vector3(transform.position.x + speedX, transform.position.y + speedY, transform.position.z);
    }
}
