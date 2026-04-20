using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
   public float speed; 
   public float AudioVolume; 
   public AudioClip explosionAudio; 
   
   void Update() {
    //shoots up: to shoot down make speed negative for enemy bullets in inspector
    transform.position += transform.up * Time.deltaTime * speed; 
   }

    void OnTriggerEnter2D(Collider2D other) {
    //Ignore if enemy bullet hits enemy
    if(other.CompareTag("Enemy") && gameObject.CompareTag("eBullet")) return; 
    //Destroy enemies tagged enemy
    if(other.CompareTag("Enemy")) {
        //explosion audio
        AudioSource.PlayClipAtPoint(explosionAudio, transform.position, AudioVolume);
        Destroy(other.gameObject); //destroy enemies
        Destroy(gameObject); //destroy bullet
    }
    //Destroy player tagged player
    else if(other.CompareTag("Player")) {
        MenuBehaviour.instance.showGameOver(); //display game over
        Destroy(other.gameObject); //destroy player
        Destroy(gameObject); //destroy bullet
    }
    //Destroy bullet if it hits the bottom or top 
    else if(other.CompareTag("BottomBorder") || other.CompareTag("TopBorder")) {
        Destroy(gameObject); //destroy bullet
    }
   }
}
