using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    private int max = 0;
    private int min = 0;

    private int guessMax = 0;
    private int guessMin = 0;

    // Start is called before the first frame update
    void Start()
    {
        this.max = 1000;
        this.min = 1;
        
        Debug.Log(getBanner());
        Debug.Log(getUserNumber(min, max));
        Debug.Log(guess(getRandomIntBetween(min, max)));
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

    private string guess(int num) {
        string guess = num.ToString();
        string template = "Is your number higher or lower than: {0}?";
        return string.Format(template, guess);
    }

    private int getRandomIntBetween(int min, int max) {
        System.Random rand = new System.Random();
        return rand.Next(min, max);
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

    public int getGuessMax() {
        return guessMax;
    }

    public void setGuessMax(int max) {
        this.guessMax = max;
    }

    public void setGuessMin(int min) {
        this.guessMin = min;
    }

    public int getGuessMin() {
        return guessMin;
    }
    
    private string getBanner() {
        return "Welcome to Wizard";
    }
}
