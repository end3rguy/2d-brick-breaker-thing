using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    Level level;
    [SerializeField]int colorIndex = 0;
    [SerializeField] Color[] colors;
    [SerializeField] int brickHealth; 
    [SerializeField] AudioClip chompSFX;
    [Range(0f,1f)][SerializeField] float sfxVOLUME;
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
        brickHealth = (brickHealth - 1);
        
        Debug.Log(collision);
        
        AudioSource.PlayClipAtPoint(chompSFX, Camera.main.transform.position, sfxVOLUME);
        if (brickHealth == 0)
        {
            level.Removebrix();
            Destroy(gameObject);
        }
        else
        {
            GetComponent<SpriteRenderer>().color = colors[colorIndex];
            colorIndex = colorIndex + 1;
        }
    }
}
