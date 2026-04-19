using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
   public float speed; 
   public float AudioVolume; 
   public AudioClip explosionAudio; 
   
   void Update() {
    //shoot up
    transform.position += transform.up * Time.deltaTime * speed; 
   }

    void OnTriggerEnter2D(Collider2D other) {
    //Destroy enemies tagged enemies
    if(other.CompareTag("Enemy")) {
        //explosion audio
        AudioSource.PlayClipAtPoint(explosionAudio, transform.position, AudioVolume);
        Destroy(other.gameObject); //destroy enemies
        Destroy(gameObject); //destroy bullet
    }
    //Destroy bullet if it hits the top
    if(other.CompareTag("TopBorder")) {
        Destroy(gameObject); 
    }
   }
}
