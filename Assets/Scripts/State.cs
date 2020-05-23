using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// Author: Luke McCann
/// <datecreated>23/05/2020</datecreated>
/// <summary>
/// State
/// 
/// model class for modelling game states.
/// </summary>

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(10,14)] [SerializeField] string storyText;

    /// <summary>
    /// Gets the storyText of the current State.
    /// </summary>
    /// <returns>string storyText</returns>
    public string getStateStory() 
    {
        return this.storyText;
    }
}
