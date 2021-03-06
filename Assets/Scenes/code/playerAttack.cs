using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAttack : MonoBehaviour
{
    private bool attacking = false;
    private float attackTimer = 0; 
    private float attackCd = 0.3f;
    public Collider2D attackTrigger;
    private Animator anim;
    void Awake()
    {
     anim = gameObject.GetComponent<Animator>();
     attackTrigger.enabled = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f") && !attacking)
        {
        attacking = true;
        attackTimer = attackCd;
        attackTrigger.enabled = true;

        }
        if (attacking)
        {
          if (attackTimer > 0)
          {
            attackTimer -= Time.deltaTime;
          }
          else
          {
           attacking = false;
           attackTrigger.enabled = false;
          }
    anim.SetBool("Attacking", attacking);
  }
}

}
