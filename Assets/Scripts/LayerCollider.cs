using UnityEngine;
using System.Collections;

public class LayerCollider : MonoBehaviour {

	LayerStates layerStates;

	void Awake() {
		layerStates = GetComponent<LayerStates> ();
	}

	void OnTriggerEnter (Collider hit) {
		if (hit.tag == "MainCamera") {
			layerStates.layerState = LayerStates.State.Fading;
		}
	}

}
