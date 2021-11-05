using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam_mov : MonoBehaviour
{
    public float speed;


    void Start()
    {
        speed = 7;
    }


    void Update()
    {
        if (17 > speed)
        {
            speed += Time.deltaTime;
        }
        else
        {
            speed = 17;
        }
        transform.Translate(speed * Time.deltaTime, 0, 0);

    }
}
