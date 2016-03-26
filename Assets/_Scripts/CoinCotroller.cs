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
		transform.Rotate (spinx, spiny, spinz);
	}
}
