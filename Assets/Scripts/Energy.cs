using UnityEngine;
using System.Collections;

public class Energy : MonoBehaviour {

	public float energyValue = 50;
	public float speed = 5f;

	void Update () {
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	}
	
	public void Throw ()
	{
		rigidbody.velocity = -Vector3.forward * speed;
	}
	
	public float GetHealth ()
	{
		return energyValue;
	}
	
	public void Consume ()
	{
		Destroy (gameObject);
	}
}
