using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class slotRoller : MonoBehaviour
{
    private List<int> numbersLeft = new List<int>();
    public GameObject evidenceList;
    public GameObject[] slots;
    public int rollLimit;
    private int slotDisplay; //temporary
    private bool rolling;
    private int time = 0;
    private int currentSlot = 0;
    private int slotBackwards = 0;
    private int rollFace = 1;
    public bool check = false;
    Random rand;
    
    void Awake(){
    }
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Slot is Active:");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time=Time.frameCount%30;
        //Debug.Log("Time is "+time);
        if(rolling&&time==0){
            if(currentSlot<3){
                slots[currentSlot].GetComponent<RollingAnimator>().startRoll();
                currentSlot++;
                Debug.Log("Started slot #"+currentSlot);
            }else if (slotBackwards<3){
                slots[slotBackwards].GetComponent<RollingAnimator>().rollNumber(rollFace);
                slotBackwards++;
                Debug.Log("Stopping slot #"+slotBackwards);
            }
            if(currentSlot==5&&slotBackwards==5){
                evidenceList.GetComponent<ManageEvidence>().findEvidence(rollFace);
                slotBackwards = 0;
                currentSlot = 0;
                rolling = false;
            }else if (currentSlot >= 3&&slotBackwards >= 3){
                currentSlot++;
                slotBackwards++;
            }
        }
    }

    public void rollNumber(){
        if (GameManager.Instance.rollLimit <= 0) {
            return;
        }
        Random rand = new Random();
        int roll = rand.Next(GameManager.Instance.numbersLeft.Count); 
        rollFace = GameManager.Instance.numbersLeft[roll];
        //Debug.Log("rolled a "+rollFace);
        rolling = true;
        GameManager.Instance.numbersLeft.RemoveAt(roll);
        /*Debug.Log("Array now contains");
        for(int i = 0; i < numbersLeft.Count; i++){
            Debug.Log(", "+numbersLeft[i]);
        }*/
        GameManager.Instance.rollLimit--;
        if (GameManager.Instance.rollLimit <= 0) {
            check = true;
        }
    }


}
