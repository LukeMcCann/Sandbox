using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(getBanner());
        Debug.Log(getUserNumber(0, 10));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    string getUserNumber(int lowest, int highest) {
        string template = "Pick a number between: {0} and {1}";
        string[] data = {lowest.ToString(), highest.ToString()};
        return string.Format(template, data);
    }

    string getBanner() {
        return "Welcome to Wizard";
    }
}
