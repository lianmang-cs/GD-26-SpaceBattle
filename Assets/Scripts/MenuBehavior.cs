using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuBehaviour : MonoBehaviour
{
    public GameObject enemyGroup;
    public GameObject waveClearPanel;  
    
    // Update is called once per frame
    void Update()
    {
        //check if all enemies are gone
        if (enemyGroup != null && enemyGroup.transform.childCount == 0) {
            //disable the player
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            player.GetComponent<PlayerBehavior>().enabled = false; 
            //display wave cleared panel
            waveClearPanel.SetActive(true); 
        }   
    }
    //continue the game
    public void continueGame() {
        //hide wave cleared panel
        waveClearPanel.SetActive(false);    
    }
    //return to main menu
    public void quitGame() {
        SceneManager.LoadScene("MainMenu");
    }
    public void goToGame() {
        SceneManager.LoadScene("GameScene"); 
    }
}