using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bar : MonoBehaviour
{

    public Slider slider;
    float promax = 1;
    public Transform Player;
    public Transform Endline;

    float maxdistance;

    void Start()
    {
        maxdistance = getDistance();
        slider.value = promax;
    }

    private void Update()
    {
        if (Player.position.x <= maxdistance && Player.position.x <= Endline.position.x)
        {
            float distance = 1 - (getDistance() / maxdistance);
            Setpro(distance);
        }
    }

    
    float getDistance()
    {
        return Vector3.Distance(Player.position, Endline.position);
    }

    public void Setpro(float barra)
    {
        slider.value = barra;
    }
}
