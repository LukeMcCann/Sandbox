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

    // Start is called before the first frame update
    void Start()
    {
        this.textComponent.text = "Welcome Adventurer.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
