using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.InputSystem;

public class ProgressText : MonoBehaviour
{
    public InkManager inkManager;

    // Start is called before the first frame update
    void Start()
    {
        inkManager = FindObjectOfType<InkManager>();

        if (inkManager == null)
        {
            Debug.Log("Ink Manager not found");
        }

        // Debug.Log("Turned on");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        inkManager.DisplayNextLine();
    }
}
