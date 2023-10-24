using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class evidenceHandler : MonoBehaviour
{
    public GameObject displayButton;
    public GameObject nameObject;
    public GameObject textWall;
    public GameObject tab;
    public GameObject[] suspects;
    public Color highlight;
    public Color standard;
    public string name;
    private bool isActive;
    private int questionsLeft = 2;

    // Start is called before the first frame update
    void Start()
    {
     isActive = false;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void enable (){
        nameObject.GetComponent<TextMeshProUGUI>().text = name;
        displayButton.SetActive(true);
        Debug.Log("button enabled");
        toggleText();
    }

    public void toggleText(){
        //Currently prefabbed buttons are not working, so toggleText can only be called on enable
        Debug.Log("Text toggling start");
        isActive = !isActive;
        Debug.Log("Active:" + isActive);
        if(isActive){
            tab.GetComponent<Image>().color = highlight;
            textWall.SetActive(true);
        }else{
            tab.GetComponent<Image>().color = standard;
            textWall.SetActive(false);
        }
    }

    public void ask (int person){
        if (questionsLeft <=0 ){

        }
        else{
            //suspects[person]
        }
    }
}
