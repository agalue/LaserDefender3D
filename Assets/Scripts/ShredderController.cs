using UnityEngine;
using System.Collections;

public class ShredderController : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if (other.tag.Contains("Projectile")) {
			Destroy (other.gameObject);
		}
	}
}
