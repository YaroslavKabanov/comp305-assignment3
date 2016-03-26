using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerCollider : MonoBehaviour {

	// private vars 
	private AudioSource[] _audioSources;
	private AudioSource _finishGameSound;
	private AudioSource _coinCollectSound;
	private AudioSource _hitEnemySound;

	// public variables 
	public GameController gameController;

	// Use this for initialization
	void Start () {
		this._audioSources = gameObject.GetComponents<AudioSource> ();
		this._finishGameSound = this._audioSources [0];
		this._coinCollectSound = this._audioSources [1];
		this._hitEnemySound = this._audioSources [2];
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter(Collider other) {
			// collision with diamond object
		if (other.gameObject.CompareTag ("coin")) {
			this._coinCollectSound.Play ();
			Destroy (other.gameObject);
			this.gameController.ScoreValue += 10;
		}

		//enemy collision 

	/*	if (other.gameObject.CompareTag ("Enemy")) {
			this.gameController.LivesValue -= 1;
			this._hitEnemySound.Play ();
		}*/
		// collision with finish object
		if (other.gameObject.CompareTag ("Finish")) {
			this._finishGameSound.Play ();
			this.gameController.WinLabel.gameObject.SetActive (true);
			this.gameController.RestartButton.gameObject.SetActive (true);

		}

	}

}
