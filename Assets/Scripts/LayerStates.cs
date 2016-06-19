using UnityEngine;
using System.Collections;
using GlobalVariables;

public class LayerStates : MonoBehaviour {

	public enum State { None, Initialize, Upcoming, Current, Fading, Success, Fail, Passed }
	public State layerState = State.None;
	State _prevLayerState = State.None;
	public State _cacheLayerState = State.None;

	/*
	#region Basic Getters/Setters
	public State CurrentState { get { return layerState; } }
	public State PrevState { get { return _prevLayerState; } }
	#endregion
	*/
	
	void Awake() {
		SetState (State.Initialize);

	}

	IEnumerator Start() {
		while (true) {
			switch (layerState) {
			case State.None:
				break;
			case State.Initialize:
				Initialize();
				break;
			case State.Upcoming:
				Upcoming ();
				break;
			case State.Current:
				Current ();
				break;
			case State.Fading:
				Fading ();
				break;
			case State.Success:
				Success ();
				break;
			case State.Fail:
				Fail ();
				break;
			case State.Passed:
				Passed ();
				break;
			}
			yield return null;
		}
	}

	void Update() {


	}

	void Initialize() {
		if (_cacheLayerState != layerState) {
			//print ("Initialize");
			transform.position = new Vector3(0f,0f,20f);
			_cacheLayerState = layerState;
			SetState (State.Upcoming);
		}
	}

	void Upcoming() {
		if (_cacheLayerState != layerState) {

			_cacheLayerState = layerState;
		}
	}

	void Current() {
		if (_cacheLayerState != layerState) {

			_cacheLayerState = layerState;
		}
	}

	void Fading() {
		if (_cacheLayerState != layerState) {

			_cacheLayerState = layerState;
		}

	}

	void Success() {
		if (_cacheLayerState != layerState) {

			_cacheLayerState = layerState;
		}

	}

	void Fail() {
		if (_cacheLayerState != layerState) {

			_cacheLayerState = layerState;
		}

	}

	void Passed() {
		if (_cacheLayerState != layerState) {

			_cacheLayerState = layerState;
		}

	}
	


	// Received by a Broadcast call
	void NextSpeed() {

	}

	void SetState(State newState) {
		_prevLayerState = layerState;
		_cacheLayerState = State.None;
		layerState = newState;
	}
}

