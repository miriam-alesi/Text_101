using UnityEngine;
using UnityEngine.UI;
using System.Collections;
public class TextController : MonoBehaviour {
	public int choice = 0; 
	public Text text;
	private enum States {cell, sheets_0, sheets_1, lock_0, lock_1, mirror, cell_mirror, freedom};
	private States myState;
	
	public void setChoice(int thisChoice) {
		choice = thisChoice;
	}
	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	// Update is called once per frame
	void Update () {
		if (myState == States.cell) {state_cell();}
		else if (myState == States.sheets_0) {state_sheets_0();}
		else if (myState == States.sheets_1) {state_sheets_1();}
		else if (myState == States.lock_0) {state_lock_0();}
		else if (myState == States.lock_1) {state_lock_1();}
		else if (myState == States.mirror) {state_mirror();}
		else if (myState == States.cell_mirror) {state_cell_mirror();}
		else if (myState == States.freedom) {state_freedom();}
		choice = 0;
	}
	void state_cell() {
		text.text = "You are in a prison cell, also known as your room, and you want to escape. There are " +
				"some black sneakers by the bed, " + "a black hoodie on the wall, and the window " +
				"which is (fortunately) locked" + " from the inside.\n\n" +
				"Press R to roll your eyes, H to reach for the hoodie and S to heave a giant sigh" ;
		if ((Input.GetKeyDown(KeyCode.S))||(choice == 1)) {myState = States.sheets_0;}
		else if ((Input.GetKeyDown(KeyCode.M))||(choice == 2)) {myState = States.mirror;}
		else if ((Input.GetKeyDown(KeyCode.L))||(choice == 3)) {myState = States.lock_0;}
	}
	void state_mirror() {
		text.text = "Your dad, is asleep.\n\n" +
			"Press C to chicken out, or R to make a run for it" ;
		if ((Input.GetKeyDown(KeyCode.T))||(choice == 1)) {myState = States.cell_mirror;}
		else if ((Input.GetKeyDown(KeyCode.R))||(choice == 2)) {myState = States.cell;}
	}
	void state_sheets_0() {
		text.text = "You can't believe he's still asleep. Surely it's " +
			"time he woke up due to the fact that you just tripped over your own feet." + 
			"The pleasures of a heavy sleeping dad " +
				"I am free!- or not\n\n" +
				"Press D to duck down behind the couch when you hear the toilet flush." ;
		if ((Input.GetKeyDown(KeyCode.R))||(choice == 1)) {myState = States.cell;}
	}
	void state_sheets_1() {
		text.text = "Crouching down behind the couch isn't going to make this" +
			"any better.\n\n" +
				"Press P to peep over the couch and into the mirrors reflection." ;
		if ((Input.GetKeyDown(KeyCode.R))||(choice == 1)) {myState = States.cell_mirror;}
	}
	void state_lock_0() {
		text.text = "This is one of those moments where you wish for the superpower of invisibility. " +
		 			"You have no idea what the " + "punishment would be if you were caught," + 
		 			"but McDonalds was seriously calling your name, " +
		 			 "and the healthy food in the fridge " +
					"was not at all appealing to you\n\n" +
					"Press T to think about your escape." ;
		if ((Input.GetKeyDown(KeyCode.R))||(choice == 1)) {myState = States.cell;}
	}
	void state_lock_1() {
		text.text = "You carefully push yourself out of the Crouching Tiger position, and turn around " +
			"so you can hop like a monkey who forgot his towel in the shower, to get to the door " +
				"you succeed in Ninja-ing your way across the room when you hear the sound of footsteps.\n\n" +
				"Press O to Open the door, or P to pretend you have a chronic case of sleepwalking." ;
		if ((Input.GetKeyDown(KeyCode.O))||(choice == 1)) {myState = States.freedom;}
		else if ((Input.GetKeyDown(KeyCode.R))||(choice == 2)) {myState = States.cell_mirror;}
	}
	void state_cell_mirror() {
		text.text = "You are relieved to hear the footsteps " + 
		"fade away and the sound of a bedroom door closing, " + "but you STILL want to escape! There is " +
			"absolutely no going back now, Greenbean! " +
				" and that pesky door is still there," + 
				" but this time, it is firmly UNLOCKED!\n\n" +
				" Press S to shimmy your way out of the door " + 
				" and P to push the door closed, quietly." ;
		if ((Input.GetKeyDown(KeyCode.S))||(choice == 1)) {myState = States.sheets_1;}
		else if ((Input.GetKeyDown(KeyCode.L))||(choice == 2)) {myState = States.lock_1;}
	}
	void state_freedom() {
		text.text = "The smell of salt and greasy fries invades your nose" + 
			" as you move closer to the only thing" + "seperating you from heaven\n\n" +
					" Welcome to McDonalds, can I take your order? " + 
					" You won, Greenbean! You won! " +
					" Press P to play again. ";
		if ((Input.GetKeyDown(KeyCode.P))||(choice == 1)) {myState = States.cell;}
	}
}