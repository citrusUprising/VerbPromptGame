using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntroHandler : MonoBehaviour
{
    private int questionsLeft = 3;
    public GameObject transition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void increment(){
        questionsLeft--;
        if(questionsLeft <= 0){
            nextScene();
        }
    }

    private void nextScene(){
        transition.SetActive(true);
    }

}
