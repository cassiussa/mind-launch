using UnityEngine;
using System.Collections;
using GlobalVariables;

public class LayerMotion : MonoBehaviour {

	public enum State { None, Initialize, First, Second, Third, Fourth, Fifth, Sixth, Seventh, Eighth, Nineth, Tenth }
	public State motionState = State.None;
	//State _prevMotionState = State.None;
	public State _cacheMotionState = State.None;

	//public global.State level;	// Test to see if I can globalize an enum - looks like I can.  Note, it's static here


	void Awake () {
		//level = global.level;	This only assigns the value, not the same reference :(
		// Set the initial state to noSpeed so that it can gather the details about game state and apply them to this layer's motion
		SetState (State.Initialize);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator Start() {
		while (true) {
			switch (motionState) {
			case State.None:
				break;
			case State.Initialize:
				Initialize ();
				break;
			case State.First:
				First ();
				break;
			case State.Second:
				Second ();
				break;
			case State.Third:
				Third ();
				break;
			case State.Fourth:
				Fourth ();
				break;
			case State.Fifth:
				Fifth ();
				break;
			case State.Sixth:
				Sixth ();
				break;
			case State.Seventh:
				Seventh ();
				break;
			case State.Eighth:
				Eighth ();
				break;
			case State.Nineth:
				Nineth ();
				break;
			case State.Tenth:
				Tenth ();
				break;
			}
			yield return null;
		}
	}
	

	void Initialize() {
		if (_cacheMotionState != motionState) {

			_cacheMotionState = motionState;
		}
		if (global.speed != 0)
			SetState (State.First);
	}

	void First() {
		transform.Translate(Vector3.forward * Time.deltaTime * -global.speed);
		if (_cacheMotionState != motionState) {

			_cacheMotionState = motionState;
		}
	}

	void Second() {
		if (_cacheMotionState != motionState) {
			
			_cacheMotionState = motionState;
		}
	}

	void Third() {
		if (_cacheMotionState != motionState) {
			
			_cacheMotionState = motionState;
		}
	}

	void Fourth() {
		if (_cacheMotionState != motionState) {
			
			_cacheMotionState = motionState;
		}
	}

	void Fifth() {
		if (_cacheMotionState != motionState) {
			
			_cacheMotionState = motionState;
		}
	}

	void Sixth() {
		if (_cacheMotionState != motionState) {
			
			_cacheMotionState = motionState;
		}
	}

	void Seventh() {
		if (_cacheMotionState != motionState) {
			
			_cacheMotionState = motionState;
		}
	}

	void Eighth() {
		if (_cacheMotionState != motionState) {
			
			_cacheMotionState = motionState;
		}
	}

	void Nineth() {
		if (_cacheMotionState != motionState) {
			
			_cacheMotionState = motionState;
		}
	}

	void Tenth() {
		if (_cacheMotionState != motionState) {
			
			_cacheMotionState = motionState;
		}
	}


	// Received by a Broadcast call
	void NextSpeed() {
		if (motionState == State.None)
			SetState (State.First);
		else if (motionState == State.First)
			SetState (State.Second);
		else if (motionState == State.Second)
			SetState (State.Third);
		else if (motionState == State.Third)
			SetState (State.Fourth);
		else if (motionState == State.Fourth)
			SetState (State.Fifth);
		else if (motionState == State.Fifth)
			SetState (State.Sixth);
		else if (motionState == State.Sixth)
			SetState (State.Seventh);
		else if (motionState == State.Seventh)
			SetState (State.Eighth);
		else if (motionState == State.Eighth)
			SetState (State.Nineth);
		else if (motionState == State.Nineth)
			SetState (State.Tenth);
		else
			Debug.LogError ("An invalid state has been reached in the LayerMotion script", gameObject);
	}

	void SetState(State newState) {
		//_prevMotionState = motionState;
		_cacheMotionState = State.None;
		motionState = newState;
	}
}
