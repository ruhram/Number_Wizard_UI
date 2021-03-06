using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    [SerializeField]int max;
    [SerializeField]int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;

    
    // Start is called before the first frame update
    void Start()
    {
        NextGuess();
        max = max + 1;
    }

    public void onPressHigher()
    {
        min = guess + 1;
        NextGuess();
    }
    public void onPressLower()
    {
        max = guess - 1;
        NextGuess();
    }
    public void NextGuess()
    {
        guess = Random.Range(min, max);
        guessText.text = guess.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
