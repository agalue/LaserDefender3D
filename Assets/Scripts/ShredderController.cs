using UnityEngine;
using System.Collections;

public class ShredderController : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		Destroy (other.gameObject);
	}
}
