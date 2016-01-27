using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	private int min;
	private int max;
	private int middle;
	private int guesses;
	private int guess;
	private int maxGuesses = 12;
	
	public Text Instructions;
	public Text MatchingGuess;
	public Text GuessesLeft;
	public Text Lower;
	public Text Higher;
	
	// Use this for initialization
	void Start () {
		max = 1000;
		min = 1;
		guesses = -1;
		
		PrintInstructions();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)){
			//print("Up Arrow was pressed");
			GuessHigher();
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow)){
			//print("Down Arrow was pressed");
			GuessLower();
		}
	}
	
	void PrintInstructions(){
		guess = Random.Range(min, max+1);
		
		guesses += 1;
		
		if(guesses >= maxGuesses){
			Application.LoadLevel("Win");
		}
		else if(maxGuesses - guesses == 1){
			Instructions.text = "Is your number " + guess + "?";
			MatchingGuess.text = "It is " + guess + "!";
			GuessesLeft.text = "My guesses left: " + (maxGuesses - guesses);
			Lower.text = "Nope!";
			Higher.text = "";
		}
		else{
			Instructions.text = "Is the number higher or lower than " + guess + "?";
			Instructions.text += "\r\nUp = higher, Down = lower";
			GuessesLeft.text = "My guesses left: " + (maxGuesses - guesses);
			MatchingGuess.text = "It is " + guess + "!";
		}
	}
	
	public void GuessHigher(){
		min = guess;
		PrintInstructions();
	}
	
	public void GuessLower(){
		max = guess;
		PrintInstructions();		
	}
}
