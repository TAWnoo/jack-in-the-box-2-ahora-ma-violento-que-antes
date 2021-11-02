using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Admin2 : MonoBehaviour
{

    void Start()
    {

    }


    void Update()
    {

    }


    private void OnCollisionEnter(Collision collision)
    {
        cambioescena4();
    }

    public void cambioescena1()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void cambioescena2()
    {
        SceneManager.LoadScene("Nivel_1.1");
    }

    public void cambioescena3()
    {
        SceneManager.LoadScene("fin");
    }

    public void cambioescena4()
    {
        SceneManager.LoadScene("Nivel_2.1");
    }
}

