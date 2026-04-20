using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    private float direction = 1f; 
    public float moveSpeed = 1f; 
    public float max;
    public float min; 
    
    public float minRateOfFire = 1f; 
    public float maxRateOfFire = 6f; 
    private float delay = 0f; 
    private float timer = 0f;
    public GameObject enemyBullet;
    // Update is called once per frame
    void Update()
    {
        Movement(); 

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
        if(enemies.Length == 0) return; //stop if no more enemies 
        int random = Random.Range(0, enemies.Length);
        //pick random enemy
        enemies[random].Shoot(); 
        
    }
    public void Movement() {
        Vector3 newPos = transform.position;
        newPos.x = newPos.x + direction * moveSpeed * Time.deltaTime; 
        //prevent movement to far right
        if (newPos.x > max) {
            newPos.x = max;
            direction = -1f; //flips direction  
        }  
        //prevent movement to far left
        if (newPos.x < min) {
            newPos.x = min; 
            direction = 1f; //flips direction
        }
        transform.position = newPos; 
    }
}
