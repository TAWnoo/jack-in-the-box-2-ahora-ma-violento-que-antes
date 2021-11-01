using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hpe : MonoBehaviour
{
    public int vidae;

    void Start()
    {
        
    }


    void Update()
    {

    }

    private void OnCollisionEnter(Collision toc)
    {
        //Debug.Log("a");
        Debug.Log("c");

        if (toc.gameObject.tag == "Weapon")
        {
            Debug.Log("b");

            if (vidae >= 1)
            {
                vidae -= 1;
            }

            else
            {
                
                Debug.Log("a");
                Victory();
            }
        }

    }

    void Victory()
    {
        SceneManager.LoadScene("fin");
    }
}
