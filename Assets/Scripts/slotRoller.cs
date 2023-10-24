using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class slotRoller : MonoBehaviour
{
    private List<int> numbersLeft = new List<int>();
    public GameObject evidenceList;
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

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void rollNumber(){
        Random rand = new Random();
        int roll = rand.Next(numbersLeft.Count);
        //////Move to SubRoutine//////
        //everything involved with spinning the slot
        evidenceList.GetComponent<ManageEvidence>().findEvidence(roll);
        //////////////////////////////
        numbersLeft.RemoveAt(roll);
    }
}
