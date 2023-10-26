using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckForFinal : MonoBehaviour
{
    public GameObject EvidenceBox;
    public GameObject Slots;
    public GameObject Leave;
    private bool isReady = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void checkFinal(){
        isReady = true;
        int arraySize = EvidenceBox.GetComponent<ManageEvidence>().items.Length;
        for (int i = 0; i < arraySize; i++){
            bool comp = EvidenceBox.GetComponentInChildren<evidenceHandler>().complete;
            bool active = EvidenceBox.GetComponentInChildren<evidenceHandler>().isAwake;
            if(!comp&&active){
                isReady = false;
            }
        }
        if(!Slots.GetComponent<slotRoller>().check){
            isReady = false;
        }
        offerEnd(isReady);
    }

    private void offerEnd(bool check){
        if(check){
            Leave.SetActive(true);
        }else{
            Debug.Log("Not all evidence has been explored");
        }
    }

    public void goToEnd(){
        //open guess scene
        //flag
    }
}
