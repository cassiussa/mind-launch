using UnityEngine;
using System.Collections;

public class LayerCurrentCollider : MonoBehaviour {

	LayerStates layerStates;

	void Awake() {
		layerStates = gameObject.transform.parent.GetComponent<LayerStates> ();
	}

	void OnTriggerEnter (Collider hit) {
		if (hit.tag == "MainCamera") {
			layerStates.layerState = LayerStates.State.Current;
		}
	}

}
