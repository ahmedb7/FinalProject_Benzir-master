using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {
	//public instance variables
	public Transform target;
	public float speed;

	//private instance variables
	private Transform _transform;
	private float _targetDistance;
	

	// Use this for initialization
	void Start () {
		this._transform = gameObject.GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		this._targetDistance = Vector3.Distance (this._transform.position, this.target.position);
		if (this._targetDistance < 30) {
			this._transform.position = Vector3.MoveTowards(this._transform.position, target.position, this.speed);
		}
	
	}
}
