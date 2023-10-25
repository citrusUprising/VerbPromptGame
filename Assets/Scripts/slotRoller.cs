using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class slotRoller : MonoBehaviour
{
    private List<int> numbersLeft = new List<int>();
    public GameObject evidenceList;
    public int rollLimit;
    Random rand;
    
    void Awake(){
        numbersLeft.Add(0);
        numbersLeft.Add(1);
        numbersLeft.Add(2);
        numbersLeft.Add(3);
        numbersLeft.Add(4);
        numbersLeft.Add(5);
        numbersLeft.Add(6);
        numbersLeft.Add(7);
        numbersLeft.Add(8);
        numbersLeft.Add(9);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Slot is Active:");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void rollNumber(){
        if (rollLimit <= 0) return;
        Random rand = new Random();
        int roll = rand.Next(numbersLeft.Count); 
        int rollFace = numbersLeft[roll];
        Debug.Log("rolled a "+rollFace);
        //////Move to SubRoutine//////
        //everything involved with spinning the slot
        evidenceList.GetComponent<ManageEvidence>().findEvidence(rollFace);
        //////////////////////////////
        numbersLeft.RemoveAt(roll); //currently having issues
        Debug.Log("Array now contains");
        for(int i = 0; i < numbersLeft.Count; i++){
            Debug.Log(", "+numbersLeft[i]);
        }
        rollLimit--;
    }


}
