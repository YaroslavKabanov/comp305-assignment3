// ********************************************
// * Source file : GameController.cs          *
// * Author name : Yaroslav Kabanov           *
// * Last Modified by : Yaroslav Kabanov      *
// * Last Date Modified : March 25th, 2016    *
// * Program Description : 3D Maze-Runner GAme*
// * Version: 0.7                             *
// ********************************************    
// Git Rero: https://github.com/YaroslavKabanov/comp305-assignment3.git

using UnityEngine;
using System.Collections;

public class CoinCotroller : MonoBehaviour {


	public int spinx = 0;
	public int spiny = 5;
	public int spinz = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// make coin rotate
		transform.Rotate (spinx, spiny, spinz);
	}
}
