using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ia : MonoBehaviour
{

    string currentState;
    public Transform target;
    float distance;
    public float chaseDist;
    public Animator anim;
    public float speed;
    public float atckDist;
    public int health;
    public int maxHealth;
    
    

    void Start()
    {
        
        currentState = "IdleState";
        target = GameObject.FindGameObjectWithTag("player").transform;
        health = maxHealth;
    }

    

    void Update()
    {
        distance = Vector3.Distance(transform.position, target.position);

        if (currentState == "IdleState")
        {
            if(distance < chaseDist)
            {
                currentState = "ChaseState";

            }

        }
        else if (currentState == "ChaseState")
        {
            anim.SetTrigger("Chase");
            anim.SetBool("Attack", false);

            if (  distance < atckDist )
            {
                currentState = "AttackState";
            }

            if (target.position.x > transform.position.x)
            {
                //derecha
                transform.Translate(transform.right * speed * Time.deltaTime);
                transform.rotation = Quaternion.Euler(0, 180, 0);
            }
            if (target.position.x < transform.position.x)
            {
                //izquierda
                transform.Translate(-transform.right * speed * Time.deltaTime);
                transform.rotation = Quaternion.Euler(0, 0, 0);
            }
        }
        else if (currentState == "AttackState")
        {
            anim.SetBool("Attack", true);
            if(distance > atckDist)
            {
                currentState = "ChaseState";
            }
        }
    }

    public void takeDamage(int damage)
    {
        health -= damage;

        if (health < 0)
        {
            Die();
        }
    }

    private void Die()
    {

    }
}
