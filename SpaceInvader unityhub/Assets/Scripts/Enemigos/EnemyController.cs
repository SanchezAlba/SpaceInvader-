using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 3.0f;
    public bool vertical;
    public float changeTime = 3.0f;

    Rigidbody rigidbody;
    float timer;
    int direction = 1;
    bool broken = true;

    Animator animator;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        timer = changeTime;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //remember ! inverse the test, so if broken is true !broken will be false and return won�t be executed.
        if (!broken)
        {
            return;
        }

        timer -= Time.deltaTime;

        if (timer < 0)
        {
            direction = -direction;
            timer = changeTime;
        }


        Vector2 position = rigidbody.position;

        if (vertical)
        {
            position.y = position.y + Time.deltaTime * speed * direction;
            animator.SetFloat("Move X", 0);
            animator.SetFloat("Move Y", direction);
        }
        else
        {
            position.x = position.x + Time.deltaTime * speed * direction;
            animator.SetFloat("Move X", direction);
            animator.SetFloat("Move Y", 0);
        }

        rigidbody.MovePosition(position);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        MovimientoNaves player = other.gameObject.GetComponent<MovimientoNaves>();

        /*  if (player != null)
          {
              player.ChangeHealth(-1);
          }
      }

      //Public because we want to call it from elsewhere like the projectile script
      public void Fix()
      {
          broken = false;
          rigidbody2D.simulated = false;
          //optional if you added the fixed animation
          animator.SetTrigger("Fixed");
      }*/
    }
}
