using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxSpeed = 3;
    public float speed = 50f;
    public float jumpPower = 150f;
    public bool grounded;
    public int curHealth;
    public int maxHealth = 100;
    private Rigidbody2D rb2d;
    private Animator anim;


    // Start is called before the first frame update
    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
        curHealth = maxHealth;

      
    }

    // Update is called once per frame
    void Update()
    {
       anim.SetBool("Grounded",grounded);
       anim.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal")));  

        if (Input.GetAxis("Horizontal") < -0.1f)
        {
          transform.localScale = new Vector3(-1, 1, 1);
        }
        if (Input.GetAxis("Horizontal") > 0.1f){
          transform.localScale = new Vector3(1, 1, 1);
        }      
        /*if(curHealth > maxHealth) 
        {
           curHealth = maxHealth;
        }
        if (curHealth <= 0)
        {
          Die();
        }
        */

    }
    void FixedUpdate()
    {
     float h = Input.GetAxis("Horizontal");
     rb2d.AddForce((Vector2.right * speed) * h);
    
     if (rb2d.velocity.x > maxSpeed)
     {
       rb2d.velocity = new Vector2(maxSpeed, rb2d.velocity.y);
     }
     if (rb2d.velocity.x < -maxSpeed)
     {
       rb2d.velocity = new Vector2(-maxSpeed, rb2d.velocity.y);
     }
    }
    /*
    void Die() {
     Application.LoadLevel (Application.loadedLevel);
    }
    */

}
