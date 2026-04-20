using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public float minRateOfFire = 1f; 
    public float maxRateOfFire = 6f; 
    private float delay = 0f; 
    private float timer = 0f;
    public GameObject enemyBullet;
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= delay) {
            randomShoot(); 
            timer = 0f; //reset timer
            delay = Random.Range(minRateOfFire, maxRateOfFire); //new delay for next shot 
        }  
    }
    public void randomShoot() {
        //get all enemies within the group
        EnemyLaunchOff[] enemies = GetComponentsInChildren<EnemyLaunchOff>(); 
        int random = Random.Range(1, enemies.Length);
        //pick random enemy
        enemies[random].Shoot(); 
        
    }
}
