using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vidap : MonoBehaviour
{
    public int hpj;

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

            if (hpj >= 1)
            {
                hpj -= 1;
            }

            else
            {

                Debug.Log("a");
                yield return new WaitForSeconds(2);
                derota();
            }
        }

    }

    void derota()
    {

        SceneManager.LoadScene("Nivel_2.1");
    }
}

