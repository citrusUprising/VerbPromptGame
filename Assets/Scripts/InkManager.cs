using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

using Ink.Runtime;

public class InkManager : MonoBehaviour
{
    [SerializeField]
    private TextAsset inkJsonAsset;
    [SerializeField]
    private GameObject dialoguePasser;
    [SerializeField]
    private TMPro.TMP_Text textField;
    [SerializeField]
    private HorizontalLayoutGroup choiceButtonContainer;
    [SerializeField]
    private Button choiceButtonPrefab;
    private Story story;
    private string inkName;

    // Start is called before the first frame update
    void Start()
    {
        dialoguePasser = GameObject.Find("DialoguePassIn");
        inkName = dialoguePasser.GetComponent<DialoguePassIn>().evidence.ToString();
        Debug.Log(inkName);
        inkJsonAsset = Resources.Load<TextAsset>("InkFiles/" + inkName);
        StartStory();

        // inkJsonAsset = 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void StartStory()
    {
        story = new Story(inkJsonAsset.text);
        DisplayNextLine();
    }

    private void DisplayChoices()
    {
        if (choiceButtonContainer.GetComponentsInChildren<Button>().Length > 0) return;
        Debug.Log("# of buttons: " + story.currentChoices.Count);
        for (int i = 0; i < story.currentChoices.Count; i++) // iterates through all choices
        {
            var choice = story.currentChoices[i];
            var button = CreateChoiceButton(choice.text); // creates a choice button

            button.onClick.AddListener(() => OnClickChoiceButton(choice));
        }
    }

    Button CreateChoiceButton(string text)
    {
        // creates the button from a prefab
        var choiceButton = Instantiate(choiceButtonPrefab);
        choiceButton.transform.SetParent(choiceButtonContainer.transform, false);
        
        // sets text on the button
        var buttonText = choiceButton.GetComponentInChildren<TMPro.TMP_Text>();
        buttonText.text = text;

        return choiceButton;
    }

    void OnClickChoiceButton(Choice choice)
    {
        story.ChooseChoiceIndex(choice.index); // tells ink which choice was selected
        RefreshChoiceView(); // removes choices from the screen
        DisplayNextLine();
    }

    void RefreshChoiceView()
    {
        if (choiceButtonContainer != null)
        {
            foreach (var button in choiceButtonContainer.GetComponentsInChildren<Button>())
            {
                Destroy(button.gameObject);
            }
        }
    }

    public void DisplayNextLine()
    {
        Debug.Log("DisplayNextLine");
        // if (!story.canContinue)
        // {
        //     // SceneManager.UnloadSceneAsync(2);
        // }
        if (story.canContinue)
        {
            Debug.Log("Continuing");
            string text = story.Continue(); // gets next line
            Debug.Log(text);
            text = text.Trim(); // removes white space from text
            Debug.Log(text);
            textField.text = text; // displays new text
        }
        else if (story.currentChoices.Count > 0)
        {
            Debug.Log("I love choices");
            DisplayChoices();
        }
        else if (story.canContinue == false)
        {
            if (inkName == "intro")
            {
                SceneManager.LoadScene(2);
            }
            else
            {
                SceneManager.UnloadSceneAsync(2);
            }
        }
    }
}
