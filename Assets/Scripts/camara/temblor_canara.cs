using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temblor_canara : MonoBehaviour
{
    public Animator anicam;
    

    void Start()
    {

    }


    void Update()
    {

    }

    
    public void camaratiembla()
    {

        anicam.SetTrigger("temblor");
    }

}
