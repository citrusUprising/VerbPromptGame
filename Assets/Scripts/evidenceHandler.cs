using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
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
    public string evidenceName;
    private bool isActive;
    public bool isAwake;
    private int questionsLeft = 2;
    public int arrayLoc;
    private GameObject[] itemRef;
    public bool complete = false;
    public GameObject mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        isAwake= false;
        isActive = false;   
        itemRef = this.GetComponentInParent<ManageEvidence>().items;

        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void enable (){
        nameObject.GetComponent<TextMeshProUGUI>().text = evidenceName;
        displayButton.SetActive(true);
        isAwake = true;
        toggleText();
    }

    public void toggleText(){
        //Debug.Log("Text toggling start");
        isActive = !isActive;
        //Debug.Log("Active:" + isActive);
        if(isActive){
            for (int i = 0; i < itemRef.Length; i++){ //disables all currently active evidence windows
                if (itemRef[i].GetComponent<evidenceHandler>().isActive){
                    itemRef[i].GetComponent<evidenceHandler>().toggleText();
                }
            }
            this.isActive = true; //reenables this evidence window
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
            if (questionsLeft <= 0 ){
                disableSuspects();
                this.GetComponentInParent<ManageEvidence>().daisyChain();
            }
            this.GetComponentInParent<ManageEvidence>().updatePasser(arrayLoc+1,person);
            mainCamera.SetActive(false);
            SceneManager.LoadScene(6, LoadSceneMode.Additive);
        }
    }

    private void disableSuspects(){
            for (int i = 0; i < suspects.Length; i++){
                suspects[i].GetComponentInChildren<Button>().enabled = false;
            }
            complete = true;
    }
}
