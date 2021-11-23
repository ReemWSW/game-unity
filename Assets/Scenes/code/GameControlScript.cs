using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameControlScript : MonoBehaviour
{
    public GameObject heart1, heart2, heart3, heart4, heart5, heart6, heart7, heart8;
    public static float health;

    // Start is called before the first frame update
    void Start()
    {
        health = 8; 
        heart1.gameObject.SetActive (true); 
        heart2.gameObject.SetActive (true); 
        heart3.gameObject.SetActive (true); 
        heart4.gameObject.SetActive (true); 
        heart5.gameObject.SetActive (true); 
        heart6.gameObject.SetActive (true); 
        heart7.gameObject.SetActive (true); 
        heart8.gameObject.SetActive (true); 
    }

    // Update is called once per frame
    void Update()
    {
      
        if (health == 0)
        {
            heart1.gameObject.SetActive (false);
            heart2.gameObject.SetActive (false);
            heart3.gameObject.SetActive (false);
            heart4.gameObject.SetActive (false);
            heart5.gameObject.SetActive (false);
            heart6.gameObject.SetActive (false);
            heart7.gameObject.SetActive (false);
            heart8.gameObject.SetActive (false);
            Application.LoadLevel(Application.loadedLevel);
        }
        else if (health == 1)
        {
            heart1.gameObject.SetActive (false);
            heart2.gameObject.SetActive (false);
            heart3.gameObject.SetActive (false);
            heart4.gameObject.SetActive (false);
            heart5.gameObject.SetActive (false);
            heart6.gameObject.SetActive (false);
            heart7.gameObject.SetActive (false);
            heart8.gameObject.SetActive (true);
        } 
         else if (health == 2)
        {
            heart1.gameObject.SetActive (false);
            heart2.gameObject.SetActive (false);
            heart3.gameObject.SetActive (false);
            heart4.gameObject.SetActive (false);
            heart5.gameObject.SetActive (false);
            heart6.gameObject.SetActive (false);
            heart7.gameObject.SetActive (true);
            heart8.gameObject.SetActive (true);
            
        }
        else if (health == 3)
        {
            heart1.gameObject.SetActive (false);
            heart2.gameObject.SetActive (false);
            heart3.gameObject.SetActive (false);
            heart4.gameObject.SetActive (false);
            heart5.gameObject.SetActive (false);
            heart6.gameObject.SetActive (true);
            heart7.gameObject.SetActive (true);
            heart8.gameObject.SetActive (true);
        }
       else if (health == 4)
        {
            heart1.gameObject.SetActive (false);
            heart2.gameObject.SetActive (false);
            heart3.gameObject.SetActive (false);
            heart4.gameObject.SetActive (false);
            heart5.gameObject.SetActive (true);
            heart6.gameObject.SetActive (true);
            heart7.gameObject.SetActive (true);
            heart8.gameObject.SetActive (true);
        }
        else if (health == 5)
        {
            heart1.gameObject.SetActive (false);
            heart2.gameObject.SetActive (false);
            heart3.gameObject.SetActive (false);
            heart4.gameObject.SetActive (true);
            heart5.gameObject.SetActive (true);
            heart6.gameObject.SetActive (true);
            heart7.gameObject.SetActive (true);
            heart8.gameObject.SetActive (true);
        }
         else if (health == 6)
        {
            heart1.gameObject.SetActive (false);
            heart2.gameObject.SetActive (false);
            heart3.gameObject.SetActive (true);
            heart4.gameObject.SetActive (true);
            heart5.gameObject.SetActive (true);
            heart6.gameObject.SetActive (true);
            heart7.gameObject.SetActive (true);
            heart8.gameObject.SetActive (true);
        }
         else if (health == 7)
        {
            heart1.gameObject.SetActive (false);
            heart2.gameObject.SetActive (true);
            heart3.gameObject.SetActive (true);
            heart4.gameObject.SetActive (true);
            heart5.gameObject.SetActive (true);
            heart6.gameObject.SetActive (true);
            heart7.gameObject.SetActive (true);
            heart8.gameObject.SetActive (true);
            
        }
        else if (health == 8)
        {
            heart1.gameObject.SetActive (true);
            heart2.gameObject.SetActive (true);
            heart3.gameObject.SetActive (true);
            heart4.gameObject.SetActive (true);
            heart5.gameObject.SetActive (true);
            heart6.gameObject.SetActive (true);
            heart7.gameObject.SetActive (true);
            heart8.gameObject.SetActive (true);
            
           }
     }
    
 
}
