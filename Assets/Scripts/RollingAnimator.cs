using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RollingAnimator : MonoBehaviour
{
    private int number = 0;
    private bool rolling = false;
    private int targetRoll;
    private int time = 0;
    private float timeF = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeF += Time.deltaTime*1;
        timeF %= 2;
        time = (int)timeF;
        if(time == 0){
            if(rolling){
                number%=10;
                number++;
                this.GetComponent<TextMeshProUGUI>().text = number.ToString();
            }else if(number != targetRoll+1){
                number%=10;
                number++;
                this.GetComponent<TextMeshProUGUI>().text = number.ToString();
            }
        }


    }

    public void startRoll(){
        rolling = true;
    }

    public void rollNumber(int target){
        targetRoll = target;
        rolling = false;
    }
}
