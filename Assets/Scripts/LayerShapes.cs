using UnityEngine;
using System.Collections;
using GlobalVariables;

public class LayerShapes : MonoBehaviour {

	public GameObject mesh1;
	public GameObject mesh2;
	public GameObject mesh3;
	public GameObject mesh4;

	public GameObject currentShape;
	public Material currentShapeMaterial;	// Reference, not value
	public Material thisShapeMaterial;		// Randomly grabbed.  Used to replace currentShapeMaterial when ready
	public int randomPosition;				// The grid position that will occupy the Current Shape
	public Material[] availableMaterials;	// These are the materials that would be available in this level
	public Material[] layerMaterials;		// These are the materials for this level that were randomly selected for this Layer

	// Use this for initialization
	void Awake () {
		currentShape = GameObject.Find ("Current Shape");
		// The the reference to the current shape's material so we can update it as needed
		currentShapeMaterial = currentShape.GetComponentInChildren<Renderer> ().material;	// Need for *Reference*, not needed for value

		// Randomize which mesh will be the Current Shape
		randomPosition = Random.Range (0, 4);		// TODO: Needs to dynamically choose range later

		availableMaterials = GameObject.Find ("/Materials/Level1").GetComponent<LevelMaterials>().materials;	// TODO: Need to be able to use any level
		layerMaterials = new Material[4];			// TODO: Need to dynamically assign array Index size later
		for(var i=0;i<4;i++) {						// TODO: Need to dynamically assign iteration length
			layerMaterials[i] = availableMaterials[global.RandomRangeExcept(0, availableMaterials.Length, randomPosition)];

			if(i == 0)
				mesh1.GetComponent<Renderer>().material = layerMaterials[i];
			else if(i == 1)
				mesh2.GetComponent<Renderer>().material = layerMaterials[i];
			else if(i == 2)
				mesh3.GetComponent<Renderer>().material = layerMaterials[i];
			else if(i == 3)
				mesh4.GetComponent<Renderer>().material = layerMaterials[i];

		}

	}

}
