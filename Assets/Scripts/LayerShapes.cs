using UnityEngine;
using System.Collections;

public class LayerShapes : MonoBehaviour {

	public GameObject mesh1;
	public GameObject mesh2;
	public GameObject mesh3;
	public GameObject mesh4;

	public GameObject currentShape;
	public Material currentShapeMaterial;	// Reference, not value
	public Material thisShapeMaterial;		// Randomly grabbed.  Used to replace currentShapeMaterial when ready
	public int randomPosition;				// The grid position that will occupy the Current Shape
	public Material[] availableMaterials;

	// Use this for initialization
	void Awake () {
		currentShape = GameObject.Find ("Current Shape");
		currentShapeMaterial = currentShape.GetComponentInChildren<Renderer> ().material;

		// Randomize which mesh will be the Current Shape
		randomPosition = Random.Range (0, 4);

		availableMaterials = GameObject.Find ("/Materials/Level1").GetComponent<LevelMaterials>().materials;
		print ("the material would be " + availableMaterials [randomPosition].name);
	}

}
