using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_player : MonoBehaviour
{

    public Animator anim;
    public GameObject arma;
    public Transform puntoArma;
    public GameObject clon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            
            clon = Instantiate(arma, puntoArma.position, Quaternion.identity);
            anim.SetBool("Attack", true);
            Destroy(clon, 1);

        }
        else if (Input.GetKeyUp(KeyCode.M))
        {
            anim.SetBool("Attack", false);
        }
        if(Input.GetKeyDown(KeyCode.N))
        {
            anim.SetBool("Hit", true);
        }
        else if (Input.GetKeyUp(KeyCode.N))
        {
            anim.SetBool("Hit", false);
        }

    }


    
}
