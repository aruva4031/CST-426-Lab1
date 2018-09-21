/* =-=-=-=-=-=-=-=-=-=-=-=-=-=-
* Author: Alejandro Ruvalcaba
* Class: CST 426
* Assignment: Lab 01
* Due Date: 6 - September - 2018
* Comments:
* 
=-=-=-=-=-=-=-=-=-=-=-=-=-=- */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Flyweight features
public abstract class FlyweightDragon
{
	private
	//for memento later on
	double id;
	//types will be 1 -> ice, 2 -> wind, 3 -> fire
	int type;
	//value 100-0
	int health;
	int exp;
	Color eyeColor;
	Color skinColor;
	double size;
	//extrinsic
	string mesh = "empty";

	public FlyweightDragon (int new_type){
		//sets up the base dragon with random values
		type = new_type;
		health = Random.Range (100, 500);
		exp = 0;
		eyeColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1);
		skinColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1);
		size = Random.Range (1, 10);


		Debug.Log ("Created A new Dragon that is Type: " + mesh + " Health: " + health);
		Debug.Log ("Exp: " + exp + " Size: " + size);
	}

	public FlyweightDragon (){
		//sets up the base dragon with random values
		type = Random.Range(1,3);
		health = Random.Range (100, 500);
		exp = 0;
		eyeColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1);
		skinColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1);
		size = Random.Range (1, 10);


		Debug.Log ("Created A new Dragon that is Type: " + mesh + " Health: " + health);
		Debug.Log ("Exp: " + exp + " Size: " + size);
	}

	//would be used to create a dragon that was already saved
	public FlyweightDragon (double load_id, int load_type, int load_health, int load_exp, Color load_eyeColor, Color load_skinColor, double load_size) {
		id = load_id;
		type = load_type;
		health = load_health;
		exp = load_exp;
		eyeColor = load_eyeColor;
		skinColor = load_skinColor;
		size = load_size;

		Debug.Log ("Loaded Dragon with ID: "+ id);
	}


	public int get_type() {
		return type;
	}

	public int get_health(){
		return health;
	}
	public int get_exp(){
		return exp;
	}
	public Color get_eye(){
		return eyeColor;
	}
	public Color get_skin(){
		return skinColor;
	}
	public double get_size(){
		return size;
	}

}

/// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
public class IceDragon: FlyweightDragon
{
	private
	//for memento later on
	double id;
	//types will be 1 -> ice, 2 -> wind, 3 -> fire
	int type;
	//value 100-0
	int health;
	int exp;
	Color eyeColor;
	Color skinColor;
	double size;
	//extrinsic
	string mesh = "ice";

	public string get_mesh(){
		return mesh;
	}
	//constructor for this type
	public IceDragon (int new_type){
		//sets up the base dragon with random values
		type = new_type;
		health = Random.Range (100, 500);
		exp = 0;
		eyeColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1);
		skinColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1);
		size = Random.Range (1, 10);


		Debug.Log ("Created A new Dragon that is Type: " + mesh + " Health: " + health);
		Debug.Log ("Exp: " + exp + " Size: " + size);
	}

}

public class WindDragon: FlyweightDragon
{
	private
	//for memento later on
	double id;
	//types will be 1 -> ice, 2 -> wind, 3 -> fire
	int type;
	//value 100-0
	int health;
	int exp;
	Color eyeColor;
	Color skinColor;
	double size;
	//extrinsic
	string mesh = "wind";

	public string get_mesh(){
		return mesh;
	}
	//constructor for this type
	public WindDragon (int new_type){
		//sets up the base dragon with random values
		type = new_type;
		health = Random.Range (100, 500);
		exp = 0;
		eyeColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1);
		skinColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1);
		size = Random.Range (1, 10);


		Debug.Log ("Created A new Dragon that is Type: " + mesh + " Health: " + health);
		Debug.Log ("Exp: " + exp + " Size: " + size);
	}
}

public class FireDragon: FlyweightDragon
{
	private
	//for memento later on
	double id;
	//types will be 1 -> ice, 2 -> wind, 3 -> fire
	int type;
	//value 100-0
	int health;
	int exp;
	Color eyeColor;
	Color skinColor;
	double size;
	//extrinsic
	string mesh = "fire";

	public string get_mesh(){
		return mesh;
	}
	//constructor for this type
	public FireDragon (int new_type){
		//sets up the base dragon with random values
		type = new_type;
		health = Random.Range (100, 500);
		exp = 0;
		eyeColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1);
		skinColor = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1);
		size = Random.Range (1, 10);


		Debug.Log ("Created A new Dragon that is Type: " + mesh + " Health: " + health);
		Debug.Log ("Exp: " + exp + " Size: " + size);
	}
}
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
public class Memento
{
	// all the variables that are unique need to be saved
	private
	double id;
	int s_type;
	int s_health;
	int s_exp;
	Color s_eyeColor;
	Color s_skinColor;
	double s_size;


	//this finction creates the save data in this 
	public Memento(int i_d, int type, int health, int exp, Color eye_color, Color skin_color, double size){
		id = i_d;
		s_type = type;
		s_health = health;
		s_exp = exp;
		s_eyeColor = eye_color;
		s_skinColor = skin_color;
		s_size = size;
		Debug.Log ("Saved Dragon with ID: " + id);
	}

}



//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/// 
public class lab1_program : MonoBehaviour {
	//number of dragons wanted by the user
	public int number_of_dragons;
	public int random_number;
	// Use this for initialization
	List<Memento> savelist = new List<Memento>();
	void Start () {
		//this is the list of all the dragons
		List<FlyweightDragon> dragons = new List<FlyweightDragon> ();
		//checks to make sure there are no save dragons
		if (savelist.Count == 0) {
			//start creating the number of dragons listed
			for (int i = 0; i < number_of_dragons; i++) {
				random_number = Random.Range (1, 3);
				//randomly determines what type of dragon it is
				if (random_number == 1) {
					dragons.Add (new IceDragon(random_number));
				} 
				else if (random_number == 2) {
					dragons.Add (new WindDragon(random_number));
				} 
				else {
					dragons.Add (new FireDragon(random_number));
				}
				//saves a memento of that dargon in the save list
				savelist.Add (new Memento (i, dragons[i].get_type(), dragons[i].get_health(), dragons[i].get_exp(), dragons[i].get_eye(), dragons[i].get_skin(), dragons[i].get_size()));
			}
		} 
		//load the dragons that are saved currently
		else {
			for (int i = 0; i < savelist.Count; i++)
			{
				//load the save data
			}
		}
	}
	

}

