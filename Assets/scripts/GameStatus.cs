using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour
{
    [SerializeField] bool autoplay = false;
    [Range(0f, 5f)] [SerializeField] float speed = 1;

    private void Awake()
    {
        int numgamestats = FindObjectsOfType<GameStatus>().Length;
        if (numgamestats > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = speed;   
    }

    public bool IsAutoPlay() {

        return autoplay;

    }
}
