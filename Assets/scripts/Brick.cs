using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    Level level;
    // Start is called before the first frame update
    void Start()
    {
        level = FindObjectOfType<Level>();
        level.Countbrix();
    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision);
        level.Removebrix();
        Destroy(gameObject);
    }
}
