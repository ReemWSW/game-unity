using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HUD : MonoBehaviour
{
      public Sprite[] HeartSprites;
      public Image HeartUI;
      private Player Player;


    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
       // HeartUI.sprite = HeartSprites[Player.curHealth];
    }
}
