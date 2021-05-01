using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    Level level;
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
        Debug.Log(collision);
        level.Removebrix();
        AudioSource.PlayClipAtPoint(chompSFX, Camera.main.transform.position, sfxVOLUME);
        Destroy(gameObject);
    }
}
