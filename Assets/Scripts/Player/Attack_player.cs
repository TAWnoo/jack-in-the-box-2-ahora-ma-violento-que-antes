using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_player : MonoBehaviour
{

    public Animator anim;
    public GameObject arma;
    public Transform puntoArma;
    public GameObject clon;

    int hit_quant;
    bool can_hit;


    // Start is called before the first frame update
    void Start()
    {
        hit_quant = 0;
        can_hit = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            clon = Instantiate(arma, puntoArma.position, Quaternion.identity);
            start_Combo();
            Destroy(clon, 1);
        }
        

    }

    void start_Combo()
    {
        if (can_hit)
        {
            hit_quant++;
        }

        if (hit_quant == 1)
        {
            anim.SetInteger("Attack", 1);
        }
    }
    
    public void check_Combo()
    {
        can_hit = false;

        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Attack_1") && hit_quant == 1)
        {
            anim.SetInteger("Attack", 0);
            can_hit = true;
            hit_quant = 0;
        }
        else if (anim.GetCurrentAnimatorStateInfo(0).IsName("Attack_1") && hit_quant >= 2)
        {
            anim.SetInteger("Attack", 2);
            can_hit = true;
        }
        else if (anim.GetCurrentAnimatorStateInfo(0).IsName("Attack_2") && hit_quant == 2)
        {
            anim.SetInteger("Attack", 0);
            can_hit = true;
            hit_quant = 0;
        }
        else if (anim.GetCurrentAnimatorStateInfo(0).IsName("Attack_2") && hit_quant >= 3)
        {
            anim.SetInteger("Attack", 3);
            can_hit = true;
        }
        else if(anim.GetCurrentAnimatorStateInfo(0).IsName("Attack_3"))
        {
            anim.SetInteger("Attack", 0);
            can_hit = true;
            hit_quant = 0;
        }

    }

}
