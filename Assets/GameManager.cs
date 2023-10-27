using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : UnitySingleton<GameManager>
{
    public GameObject mainCamera;
    public GameObject slotRoller;
    public List<int> numbersLeft = new List<int>();

    [SerializeField]
    public int rollLimit;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            numbersLeft.Add(i);
        }

        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
        slotRoller = GameObject.Find("Canvas");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EvidenceToDialogue()
    {
        Debug.Log("Evidence To Dialogue");
        mainCamera.SetActive(false);
        SceneManager.LoadScene(6, LoadSceneMode.Additive);
    }
    public void DialogueToEvidence()
    {
        Debug.Log("Dialogue to Evidence");
        SceneManager.UnloadSceneAsync(6);
        slotRoller.SetActive(false);
        slotRoller.SetActive(true);
        mainCamera.SetActive(true);
    }
}
