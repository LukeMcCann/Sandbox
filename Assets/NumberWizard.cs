using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        printBanner();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void printBanner() {
        Debug.Log("*************************");
        Debug.Log("     Welcome to Wizard     ");
        print("*************************");
    }
}
