using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroButton : MonoBehaviour
{
    public GameObject passIn;
    public GameObject self;
    public int suspect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void open(){
        passIn.GetComponent<DialoguePassIn>().character = suspect;
        passIn.GetComponent<DialoguePassIn>().evidence = 0;
        selfCancel();
        SceneManager.LoadScene(6, LoadSceneMode.Additive);
    }

    private void selfCancel(){
        self.SetActive(false);
    }
}
