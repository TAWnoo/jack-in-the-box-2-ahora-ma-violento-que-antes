using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ataque : MonoBehaviour
{

    public Animator anim;
    public GameObject arma;
    public Transform puntoArma;
    public Transform Diente;
    public LayerMask playerLayer;
    public GameObject clon;


    

    void Start()
    {
        
    }

    
    void Update()
    {



        if (Input.GetKeyDown(KeyCode.N))
        {
            clon = Instantiate(arma, puntoArma.position, Quaternion.identity);
            anim.SetBool("Attack", true);
            Destroy(clon);

        }
        else if (Input.GetKeyUp(KeyCode.N))
        {
            anim.SetBool("Attack", false);
        }
    }

    
}
