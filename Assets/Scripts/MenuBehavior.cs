using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuBehaviour : MonoBehaviour
{
    public GameObject enemyGroup;
    public GameObject waveClearPanel;
    public GameObject gameOverPanel;  
    public static MenuBehaviour instance;  
    void Awake() {
        instance = this; 
    }
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
        //CONTINUE DOESN'T WORK YET

        //replay the game
        SceneManager.LoadScene("GameScene");     
    }
    //return to main menu
    public void quitGame() {
        SceneManager.LoadScene("MainMenu");
    }
    public void goToGame() {
        SceneManager.LoadScene("GameScene"); 
    }
    public void showGameOver() {
        //disable the enemies
        enemyGroup.SetActive(false); 
        gameOverPanel.SetActive(true); 
    }
}