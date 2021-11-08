using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hpe : MonoBehaviour
{
    public int vidae;
    public Animator anim;

    void Start()
    {
        
    }


    void Update()
    {

    }

    private IEnumerator OnCollisionEnter(Collision toc)
    {
        

        if (toc.gameObject.tag == "Weapon")
        {
            Debug.Log("b");
            anim.SetBool("Hit", true);

            if (vidae >= 1)
            {
                vidae -= 1;
                anim.SetBool("Death", false);
            }

            else
            {
                anim.SetBool("Death", true);
                Debug.Log("a");
                yield return new WaitForSeconds(2);
                Victory();
            }
        }
        else
        {
            anim.SetBool("Hit", false);
        }

    }

    void Victory()
    {
        
        SceneManager.LoadScene("fin");
    }
}
