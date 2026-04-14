using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehavior : MonoBehaviour
{
    public float speed; 
    public float min; 
    public float max; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        
    }

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
        
    }
}
