using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerCollider : MonoBehaviour {
	//PUBLIC INSTANCE VARIABLES
	public Text scoreText;      //makes a reference to scoreboard
	public Text lifeText;
	public Text collectText;
	public Text dirText;
	public int  scoreValue = 0;
	public int  lifeValue = 100;
	public int  collectValue = 0;
	public GameObject other;
	public CharacterController controller; //makes a reference to player controller
	
	
	private bool gameOver;
	private bool restart;
	
	
	
	/*private AudioSource[] soundClips; //array of sound clips
	private AudioSource coin, death, explosion, life;*/
	
	
	// Use this for initialization
	void Start () {
		
		
	
		this._SetScore ();
		this.dirText.enabled = false;

		/*this.soundClips = gameObject.GetComponents<AudioSource>();  //get audio sources from player
		this.coin = soundClips[0];
		this.explosion = soundClips[1];
		//this.life = soundClips[2];
		this.death = soundClips [2];*/
		
		
		UpdateScore();
		UpdateLife();
	}
	
	// Update is called once per frame
	void Update () {

		if (this.lifeValue <= 0) {
			Application.LoadLevel("GameOver");
		}
		
	}
	
	
	// When player scores a point
	public void GainScore(int newScoreValue)
	{
		scoreValue += newScoreValue;
		UpdateScore();
	}
	
	// Updates score value from above
	public void UpdateScore()
	{
		scoreText.text = "Score: " + scoreValue; //updates score
	}
	
	// When player collides with a Enemy
	public void LoseLife(int newLifeValue)
	{
		lifeValue -= newLifeValue;  
		UpdateLife();
	}
	
	public void UpdateLife()
	{
		lifeText.text = "Life: " + lifeValue; //updates life value
		
	}
	void OnTriggerEnter (Collider other) {
		
		if (other.tag == "Coin") {
			this.scoreValue += 10; // adds 10 points
			this.collectValue += 1;
			//this.coin.Play (); // plays coin audio
			
		}
		if (other.tag == "Health") {
			//this.life.Play (); //plays life audio
			this.lifeValue += 1; // adds 1 life
			
		}
		if (other.tag == "Mine") {
			this.lifeValue -= 20; // loose 10 life
			//this.explosion.Play ();
			if (this.lifeValue <= 0) {  //ends the game when you have 0 or less lives
				//this.death.Play ();  //plays death audio
				this._EndGame ();
			}
		}
			/*if (other.tag == "EnemyAI") {
			//this.explosion.Play ();
			this.lifeValue -= 50; // loose 10 life
			if (this.lifeValue <= 0) {  //ends the game when you have 0 or less lives
				//this.death.Play ();  //plays death audio
				this._EndGame ();
				}
			}*/

			
			
		
		if (other.tag == "Death") {
			Application.LoadLevel("GameOver");
			//this.death.Play ();			
		}
		
		
		
		this._SetScore ();
		
		if (this.scoreValue == 100) {

			this.dirText.enabled = true;
			this.scoreText.enabled = false;
			this.lifeText.enabled = false;
			this.collectText.enabled = false;// Makes game over, final score, restart text appear when game ends 
			
			
		}
	}
	
	
	// PRIVATE METHODS
	private void _SetScore() {
		this.scoreText.text = "Score: " + this.scoreValue;
		this.lifeText.text = "Life: " + this.lifeValue;
		this.collectText.text = "Coin's Collected: "+this.collectValue+"/10";
	}
	
	
	
	
	//ends game displays game over text
	private void _EndGame() {
		
		//this.dead.Play ();
		Application.LoadLevel ("GameOver");
		
	}
}
