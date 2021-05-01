using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteelBarrier : MonoBehaviour
{
    [SerializeField] AudioClip clangSFX;
    [Range(0f, 1f)] [SerializeField] float sfxVOLUME;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision);
       
        AudioSource.PlayClipAtPoint(clangSFX, Camera.main.transform.position, sfxVOLUME);
        
    }
}
