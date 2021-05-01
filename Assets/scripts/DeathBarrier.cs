using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathBarrier : MonoBehaviour
{
    [SerializeField] AudioClip deathSFX;
    [Range(0f, 1f)] [SerializeField] float sfxVOLUME;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision);
        AudioSource.PlayClipAtPoint(deathSFX, Camera.main.transform.position, sfxVOLUME);
        SceneManager.LoadScene("game over");
    }
}

