using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrounCheck : MonoBehaviour
{
    private Player player;

    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.GetComponentInParent<Player>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        player.grounded = true;  
    }
    void OnTriggerExit2D(Collider2D col)
    {
        player.grounded = false;
    }

    void Update()
    {
        
    }
}
