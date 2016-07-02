using UnityEngine;
using System.Collections;
using GlobalVariables;

public class LayerFade : MonoBehaviour {
	public Renderer[] childRenderers;

	public bool fadeOut = false;
	private float alphaCounter = 1f;
	public Color colour;
	public float coloura;
	public Color colourInvisible;
	public Color colourVisible;
	public Camera camera;
	public float distance;
	public float fadeAmount;

	public LayerStates layerStates;

	void Awake () {

		layerStates = GetComponent<LayerStates> ();
		camera = GameObject.Find ("Main Camera").camera;
		/* 
		 * First we need to determine how large the array of children
		 * with Renderers is going to be so that we can update the
		 * childRenderers arrays size
		 */
		int rendererCount = 0;
		foreach (Transform transformChild in transform) {
			if(transformChild.gameObject.GetComponent<Renderer>()) {
				rendererCount++;
			}
		}

		childRenderers = new Renderer[rendererCount];							// Set the new array size
		int rendererIterator = 0;												// Set up an iterator count so we can add renderers into array and set up material Colors
		foreach (Transform transformChild in transform) {						// Iterate through all the child transforms of this Shape Layer
			if(transformChild.gameObject.GetComponent<Renderer>()) {			// Check to see if this child has a renderer component
				Renderer thisRenderer = transformChild.gameObject.GetComponent<Renderer>();	// Cache this iteration's Renderer
				childRenderers[rendererIterator] = thisRenderer;				// Add it into the array
				Color col = thisRenderer.material.color;						// Cache the Color
				var newMat = new Color(col.r, col.g, col.b, 1);					// Create a new Color reference
				thisRenderer.material.color = newMat;							// Set the renderer material's colour to the newMat variable reference
				rendererIterator++;												// Increment the iteration counter
			}
		}
	}

	void Update () {
		distance = Vector3.Distance (transform.position, camera.transform.position);
		ChangeAlpha();
	}
	
	void ChangeAlpha(){
		if (fadeOut == true) {
			alphaCounter -= Time.deltaTime / global.fadeTime;							// or we're subtracting time

			if (alphaCounter < 0) {
				alphaCounter = Mathf.Clamp01 (alphaCounter);
				layerStates.layerState = LayerStates.State.Fail;						// Totally faded out and no success or failure yet
			} else if (alphaCounter != 0 && alphaCounter != 1) {
				alphaCounter = Mathf.Clamp01 (alphaCounter);							// Clamp the range
				colour = Color.Lerp (colourInvisible, colourVisible, alphaCounter);		// Lerp between the invisible colour and the fully opaque colour
				coloura = colour.a;
				foreach (Renderer childMaterial in childRenderers) {
					Color newMat = new Color (childMaterial.material.color.r, childMaterial.material.color.g, childMaterial.material.color.b, colour.a);
					childMaterial.material.color = newMat;								// Assign a standardized material to the circles
				}

			}
		} else if(distance > 10) {
			fadeAmount = (255-((distance-10)*15))/255;
			foreach (Renderer childMaterial in childRenderers) {
				//colour.a = fadeAmount;		// Lerp between the invisible colour and the fully opaque colour
				Color newMat = new Color (childMaterial.material.color.r, childMaterial.material.color.g, childMaterial.material.color.b, fadeAmount);
				childMaterial.material.color = newMat;								// Assign a standardized material to the circles
			}
		}
	}
	
}
