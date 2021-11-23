using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{
    private bool attacking = false;
    public int index; 
    public string levelName;
    public GameObject PauseUI;
    private bool enter = false;
       
    
    void OnTriggerEnter2D(Collider2D other)
    {
      if (other.CompareTag("Player"))
    {
          SceneManager.LoadScene(index);
          SceneManager.LoadScene("level2");
    }
    }
        
    // Start is called before the first frame update
    void Start()
    {
        PauseUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       
     
  
 }
  
}
