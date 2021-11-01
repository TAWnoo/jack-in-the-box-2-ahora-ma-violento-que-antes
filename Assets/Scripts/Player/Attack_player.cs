using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_player : MonoBehaviour
{

    public Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            Attack();
        }
        else if (Input.GetKeyUp(KeyCode.M))
        {
            anim.SetBool("Attack", false);
        }

    }


    void Attack()
    {
        anim.SetBool("Attack", true);
    }
}
