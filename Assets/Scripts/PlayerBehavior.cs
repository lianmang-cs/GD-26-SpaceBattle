using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehavior : MonoBehaviour
{
    public float speed; 
    public float min; 
    public float max; 
    public float AudioVolume; 

    public BulletBehavior playerBullet; 
    public Transform launchOff; 
    public AudioClip shootAudio;

    // Update is called once per frame
    void Update()
    {
        float offset = 0.0f; 
        //Left move
        if (Keyboard.current.leftArrowKey.isPressed || Keyboard.current.aKey.isPressed) {
            offset = -speed;
        }
        //Right move
        if (Keyboard.current.rightArrowKey.isPressed || Keyboard.current.dKey.isPressed) {
            offset = speed; 
        } 
        Vector3 newPos = transform.position;
        newPos.x = newPos.x + offset * Time.deltaTime; 
        //prevent movement to far right
        if (newPos.x > max) {
            newPos.x = max; 
        }  
        //prevent movement to far left
        if (newPos.x < min) {
            newPos.x = min; 
        }
        transform.position = newPos; 

        //Shooting
        if (Keyboard.current.spaceKey.wasPressedThisFrame) {
            //shooting audio
            AudioSource.PlayClipAtPoint(shootAudio, transform.position, AudioVolume); 
            Instantiate(playerBullet, launchOff.position, transform.rotation);

        }

        
    }
}
