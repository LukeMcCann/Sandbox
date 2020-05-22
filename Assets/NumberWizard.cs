using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    private int max = 1000;
    private int min = 1;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(getBanner());
        Debug.Log(getUserNumber(min, max));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Game Methods
    private string getUserNumber(int lowest, int highest) {
        string template = "Pick a number between: {0} and {1} inclusive.";
        string[] data = {lowest.ToString(), highest.ToString()};
        return string.Format(template, data);
    }

    // Getter/Setters
    public int getMax() {
        return max;
    }

    public void setMax(int max) {
        this.max = max;
    }

    public int getMin() {
        return min;
    }

    public void setMin(int min) {
        this.min = min;
    }
    

    private string getBanner() {
        return "Welcome to Wizard";
    }
}
