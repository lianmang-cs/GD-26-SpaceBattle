using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
   public float speed; 
   
   void Start() {
    Destroy(gameObject); 
   }


   
   void OnTriggerEnter2D(Collider2D other) {
    //Destroy enemies tagged enemies
    if(other.CompareTag("Enemy")) {
        Destroy(other.gameObject) //destroy enemies
        Destroy(gameObject) //destroy bullet
    }
    //Destroy bullet if it hits the top
    if(other.CompareTag("TopBorder")) {
        Destroy(gameObject); 
    }
   }
}
