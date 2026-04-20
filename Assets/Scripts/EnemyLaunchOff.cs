using UnityEngine;

public class EnemyLaunchOff : MonoBehaviour
{
    public BulletBehavior enemyBullet;
    public Transform launchOff; 

    public void Shoot()
    {
       Instantiate(enemyBullet, launchOff.position, transform.rotation);  
    }
}
