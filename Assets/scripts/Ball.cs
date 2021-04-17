using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Paddle paddle;
    Vector2 paddleballoffdset;
    [SerializeField] Vector2 launchvelocity;
    bool launched = false; 
    // Start is called before the first frame update
    void Start()
    {
        paddleballoffdset = transform.position - paddle.transform.position;  
    }

    // Update is called once per frame
    void Update()
    {
        if (!launched)
        {
            Lockball2paddle();
            Launchonclick();
        } 
    }
    void Lockball2paddle() {
       

        Vector2 paddlepos = new Vector2(paddle.transform.position.x, paddle.transform.position.y);
        transform.position = paddlepos + paddleballoffdset;
    }
    void Launchonclick()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().velocity=launchvelocity;
            launched = true;
        }
    }
}
