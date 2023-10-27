using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Ink.Runtime;

public class InkManager : MonoBehaviour
{
    [SerializeField]
    private TextAsset inkJsonAsset;
    private Story story;

    [SerializeField]
    private TMPro.TMP_Text textField;

    [SerializeField]
    private HorizontalLayoutGroup choiceButtonContainer;

    [SerializeField]
    private Button choiceButtonPrefab;

    // Start is called before the first frame update
    void Start()
    {
        StartStory();
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
        if (story.canContinue)
        {
            string text = story.Continue(); // gets next line
            
            text = text.Trim(); // removes white space from text
            
            textField.text = text; // displays new text
        }
        else if (story.currentChoices.Count > 0)
        {
            DisplayChoices();
        }
    }
}
