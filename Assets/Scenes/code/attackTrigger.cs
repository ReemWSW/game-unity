using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackTrigger : MonoBehaviour
{
    public int dmg = 20;
    void OnTriggerEnter2D(Collider2D col)
    {
      if (col.isTrigger != true && col.CompareTag("enemy"))
      {
         col.SendMessageUpwards ("Damage", dmg);
      }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}








