using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	public float speed;

	private Rigidbody rb;

	public GameObject TLenemy;

	public GameObject BLenemy;

	public GameObject BRenemy;

	public GameObject TRenemy;

	// Use this for initialization
	void Start () 
	{
		TLenemy = GameObject.Find ("TopLeftEnemy");
		BLenemy	= GameObject.Find ("BottomLeftEnemy");
		BRenemy = GameObject.Find ("BottomRightEnemy");
		TRenemy = GameObject.Find ("TopRightEnemy");
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate()
	{
		transform.localPosition += transform.forward * speed * Time.deltaTime;
	}

	// Update is called once per frame
	void OnCollisionEnter (Collision other) {
		if (other.gameObject = TLenemy)
		{
			
		}
	}
}
