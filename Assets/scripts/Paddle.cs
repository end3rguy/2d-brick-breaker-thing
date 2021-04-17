using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float minx;
    [SerializeField] float maxx;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 paddleposition = new Vector2 (transform.position.x, transform.position.y);
        float mousexpostion = Input.mousePosition.x;
        //Debug.Log(mousexpostion/Screen.width*16f);
        paddleposition.x = Mathf.Clamp(mousexpostion / Screen.width * 16f, minx, maxx);
        transform.position = paddleposition;

    }
}
