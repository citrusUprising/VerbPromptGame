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
    public int arrayLoc;
    private GameObject[] itemRef;

    // Start is called before the first frame update
    void Start()
    {
     isActive = false;   
     itemRef = this.GetComponentInParent<ManageEvidence>().items;
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
        //Debug.Log("Text toggling start");
        isActive = !isActive;
        //Debug.Log("Active:" + isActive);
        if(isActive){
            for (int i = 0; i < itemRef.Length; i++){
                if (itemRef[i].GetComponent<evidenceHandler>().isActive){
                    itemRef[i].GetComponent<evidenceHandler>().toggleText();
                }
            }
            this.isActive = true;
            tab.GetComponent<Image>().color = highlight;
            textWall.SetActive(true);
            
        }else{
            tab.GetComponent<Image>().color = standard;
            textWall.SetActive(false);
        }
    }

    public void ask (int person){
        //Debug.Log("Interviewing Person#"+(person+1));
        if (questionsLeft > 0 ){
            suspects[person].GetComponentInChildren<Button>().enabled = false;
            suspects[person].GetComponentInChildren<TextMeshProUGUI>().enabled = true;
            suspects[person].GetComponent<Image>().enabled = true;
            questionsLeft --;
            //open interrogation (person, arrayLoc+1);
        }
        else{
            disableSuspects();
        }
    }

    private void disableSuspects(){
            for (int i = 0; i < suspects.Length; i++){
                suspects[i].GetComponentInChildren<Button>().enabled = false;
            }
    }
}
