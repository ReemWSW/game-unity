using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] 
    Transform player;

    [SerializeField] 
    float agroRange;

    [SerializeField] 
    float moveSpeed;

    Rigidbody2D rb2d;
    public int curHealth;

    void Start()
    {
      rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       float distToPlayer = Vector2.Distance(transform.position, player.position);

       if(distToPlayer < agroRange)
       {
       //code to chase player 
       ChasePlayer();
       }
       else
       {
       //stop chasing player 
       StopChasingPlayer();
       }   
       
       if (curHealth <= 0){
          Destroy (gameObject);
       }
       

    }
      void ChasePlayer()
       {
        if(transform.position.x < player.position.x)
         {
          //enemy is to the left side of the player, so move right 
          rb2d.velocity = new Vector2(moveSpeed, 0);
          transform.localScale = new Vector2(-1, 1);
         }
        else
         {
         //enemy is to the right side of the player, so move left 
         rb2d.velocity = new Vector2(-moveSpeed, 0); 
         transform.localScale = new Vector2(1, 1);
         }

       }
       void StopChasingPlayer()
       {
        rb2d.velocity = new Vector2(0, 0);
       }
       
       public void Damage(int damage)
       {
          curHealth -= damage; 
          gameObject.GetComponent<Animation>().Play("enamy_Sleep");
       }
       


}
