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
    public Color highlight;
    public Color standard;
    public string name;
    private bool isActive;
    public int questionsLeft = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void enable (){
        nameObject.GetComponent<TextMeshProUGUI>().text = name;
        //displayButton.GetComponent<Button>().;
    }

    public void toggleText(){
        //if(textWall.isActive) textWall.disabl
        isActive = !isActive;
        if(isActive){
            tab.GetComponent<Image>().color = highlight;
        }else{
            tab.GetComponent<Image>().color = standard;
        }
    }
}
