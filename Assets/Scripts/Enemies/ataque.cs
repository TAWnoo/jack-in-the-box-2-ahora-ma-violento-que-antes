using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ataque : MonoBehaviour
{

    public Animator anim;
    public GameObject arma;
    public Transform puntoArma;
    public bool ataca;
    public Transform Diente;
    public LayerMask playerLayer;
    public GameObject clon;


    

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(1);
        ataca = Physics.CheckSphere(Diente.position, 0.2f, playerLayer);

        if (ataca)
        {
            clon = Instantiate(arma, puntoArma.position, Quaternion.identity);
            anim.SetBool("Attack", true);
            Destroy(clon, 1);

        }
        else
        {
            anim.SetBool("Attack", false);
        }
    }
}
