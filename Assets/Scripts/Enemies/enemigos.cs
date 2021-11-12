using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemigos : MonoBehaviour
{

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 7;
    }

    // Update is called once per frame
    void Update()
    {
        if (17 > speed)
        {
            speed += Time.deltaTime;
        }
        else
        {
            speed = 17;
        }
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    private void OnCollisionEnter(Collision toc)
    {

        
        SceneManager.LoadScene("Nivel_1.1");
        
    }

}
