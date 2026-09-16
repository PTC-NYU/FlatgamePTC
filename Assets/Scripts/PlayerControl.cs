using UnityEditor.Timeline;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    
    public float playerSpeed;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        Vector3 newPos = transform.position;
        
        if (Input.GetKey(KeyCode.W))
        {
            newPos.y += playerSpeed * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            newPos.y -= playerSpeed * Time.deltaTime;
        }

        
        if (Input.GetKey(KeyCode.D))
        {
            newPos.x += playerSpeed * Time.deltaTime;
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            newPos.x -= playerSpeed * Time.deltaTime;
        }
        
        transform.position = newPos;
    }
}
