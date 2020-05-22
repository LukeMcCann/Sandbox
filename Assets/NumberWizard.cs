using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The main NumberWizard
/// contains all methods for running NumberWizard
/// </summary>
/// <author>
/// Luke McCann
/// </author>
public class NumberWizard : MonoBehaviour
{
    private int max = 0;
    private int min = 0;

    private int guessMax = 0;
    private int currentGuess = 0;
    private int guessMin = 0;

    // Start is called before the first frame update
    void Start()
    {
        reset();

        Debug.Log(getBanner());
        Debug.Log(guessUserNumber(min, max));
        Debug.Log(guess(getRandomIntBetween(min, max)));
        Debug.Log("Press ↓ if lower, ↑ if higher, Enter if equal");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow)) {
            guessMax = currentGuess;
            Debug.Log(guessAgain());
        } else if(Input.GetKeyDown(KeyCode.UpArrow)) {
            guessMin = currentGuess;
            Debug.Log(guessAgain());
        } else if(Input.GetKeyDown(KeyCode.KeypadEnter)) {
            string template = "I knew your number was {0} all along!";
            Debug.Log(string.Format(template, currentGuess));
        }
    }

    // Game Methods
    private string guessUserNumber(int lowest, int highest) {
        string template = "Pick a number between: {0} and {1} inclusive.";
        string[] data = {lowest.ToString(), highest.ToString()};
        return string.Format(template, data);
    }

    private string guessAgain() {
        if(guessMin > guessMax) {
            int temp = guessMax;
            guessMax = guessMin;
            guessMin = temp;
        }
        string template = "Really? Okay then... your number must be {0}?";
        int rInt = getRandomIntBetween(guessMin, guessMax);
        return string.Format(template, rInt);
    }

    /// <summary>
    /// Guesses the user input
    /// </summary>
    /// <param name="num">the number to guess</param>
    /// <returns>string asking if number is higher or lower</returns>
    private string guess(int num) {
        this.currentGuess = num;
        string guess = num.ToString();
        string template = "Is your number higher or lower than: {0}?";
        return string.Format(template, guess);
    }

    /// <summary>
    /// Generate a random integer between min and max values.
    /// </summary>
    /// <param name="min">The minimum integer to generate (inclusive)</param>
    /// <param name="max">The maximum integer to generate (inclusive)</param>
    /// <returns>random between two integers</returns>
    private int getRandomIntBetween(int min, int max) {
        System.Random rand = new System.Random();
        return rand.Next(min, max);
    }

    private void reset() {
        this.max = 1000;
        this.min = 1;
        this.currentGuess = 0;
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
