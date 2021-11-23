/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{

    public GameObject PauseUI;
    private bool paused = false;
    public int index; 
    public string levelName;
    private bool enter = false;

    // Start is called before the first frame update
    void Start()
    {
        PauseUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown ("Pause")){
          paused = !paused;
        }
        if (paused) {
          SceneManager.LoadScene(index);
          SceneManager.LoadScene("level2");
        }
        if(!paused) {
          PauseUI.SetActive(false); 
          Time.timeScale = 1;
        }

    }
    public void Resume() {
      paused = false;
    }
    public void Restart() 
    {
      Application.LoadLevel(Application.loadedLevel);
    }
    public void MainMenu() {
      Application.LoadLevel(0);
    }
    public void Quit() {
      Application.LoadLevel(0);
    }

}
*/