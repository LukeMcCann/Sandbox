using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextQuestGame : MonoBehaviour
{
    [SerializeField] Text textComponent;

    // Start is called before the first frame update
    void Start()
    {
        this.textComponent.text = "Welcome Adventurer";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
