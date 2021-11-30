using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class vidap : MonoBehaviour
{
    public int hpj;
    //private temblor_canara temcam;

    void Start()
    {
        //temcam = GameObject.FindGameObjectsWithTag("tiembla").GetComponent<temblor_canara>();
    }


    void Update()
    {
       // temcam.camtiembla();
    }

    private IEnumerator OnCollisionEnter(Collision toc)
    {


        if (toc.gameObject.tag == "arma")
        {
            Debug.Log("b");

            if (hpj >= 1)
            {
                hpj -= 1;
            }

            else
            {

                Debug.Log("a");
                yield return new WaitForSeconds(3);
                derota();
            }
        }

    }

    void derota()
    {

        SceneManager.LoadScene("Nivel_2.1");
    }
}

