using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Button(int scene){
        Debug.Log("Transitioning Scene");
        SceneManager.LoadScene(scene);
        
    }

    public void Additive(int scene){
        SceneManager.LoadScene(scene, LoadSceneMode.Additive);
    }
}
