using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ManageEvidence : MonoBehaviour
{
    public GameObject[] items;
    public GameObject checker;
    public GameObject passer;
    public EnumHolder.Evidence evidenceType;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void findEvidence(int i){
        items[i].GetComponent<evidenceHandler>().enable();
        //Debug.Log("Enabled Evidence #"+(i+1));
    }

    public void daisyChain(){
        checker.GetComponent<CheckForFinal>().checkFinal();
    }

    public void updatePasser(int evidence, int suspect){
        evidenceType = (EnumHolder.Evidence) evidence;

        passer.GetComponent<DialoguePassIn>().character = suspect;
        passer.GetComponent<DialoguePassIn>().evidence = evidenceType;
    }

}
