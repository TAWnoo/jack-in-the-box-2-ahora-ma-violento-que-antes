using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hpe : MonoBehaviour
{
    public int vidae;

    void Start()
    {
        vidae = 4;
    }


    void Update()
    {

    }

    private void OnCollisionEnter(Collision toc)
    {
        //Debug.Log("a");

        if (toc.gameObject.tag == "weapon")
        {
            

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
