using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// Author: Luke McCann
/// <datecreated>23/05/2020</datecreated>
/// <summary>
/// TextQuestGame
/// 
/// main entry point for starting the TextQuest game.
/// </summary>
public class TextQuestGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    State state;

    // Start is called before the first frame update
    void Start()
    {
        this.state = this.startingState;
        this.textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState() 
    {
        var states = state.GetNextStates();
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = states[0];
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = states[1];
        }
        else if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = states[2];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            state = states[3];
        }
        textComponent.text = state.GetStateStory();
    }
}
