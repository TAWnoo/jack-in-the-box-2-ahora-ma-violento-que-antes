using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam_mov : MonoBehaviour
{
    public int speed;


    void Start()
    {
        speed = 7;
    }


    void Update()
    {

        transform.Translate(speed * Time.deltaTime, 0, 0);

    }
}
