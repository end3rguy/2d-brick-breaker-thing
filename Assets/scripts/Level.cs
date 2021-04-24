using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int numbrix = 0;
     SceneLoader sceneloader;
    // Start is called before the first frame update
    void Start()
    {
        sceneloader = FindObjectOfType<SceneLoader>();
    }
    public void Countbrix() {

        numbrix = numbrix + 1;

    }
    public void Removebrix() {

        numbrix = numbrix - 1;

        if (numbrix == 0) {

            sceneloader.LoadNextScene();

        }


    }
}
