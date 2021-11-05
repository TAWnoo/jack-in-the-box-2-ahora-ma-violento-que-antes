using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ataque : MonoBehaviour
{

    public Animator anim;
    public GameObject arma;
    public Transform puntoArma;
    public bool Ataca;


    
    void Start()
    {
        
    }

    
    void Update()
    {
    

            Ataca = Physics.CheckSphere(diente.position, 0.2f, groundLayer);

            GameObject clon;
            clon = Instantiate(arma, puntoArma.position, Quaternion.identity);
            anim.SetBool("Attack", true);
            Destroy(clon, 1);

        
        
        
            anim.SetBool("Attack", false);
        
    }
}
