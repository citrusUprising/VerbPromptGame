using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : UnitySingleton<GameManager>
{
    public GameObject mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera");
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
        mainCamera.SetActive(true);
    }
}
