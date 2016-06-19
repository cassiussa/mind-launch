using UnityEngine;
using System.Collections;

namespace GlobalVariables {
	public class global : MonoBehaviour {
		public enum State { None, Initialize, HomeScreen, Results, Credits, One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten }
		public State levelState = State.None;
		State _prevLevelState = State.None;
		public State _cacheLevelState = State.None;

		public static float speed = 0f;	// Revert back to this when i find the problem
		//public  float speed = 0f;

		void Awake () {
			// Set the initial state to Initialize so that it can gather the details about game state and apply them to this layer's motion
			SetState (State.Initialize);
		}

		// Update is called once per frame
		void Update () {
			
		}

		IEnumerator Start() {
			while (true) {
				switch (levelState) {
				case State.None:
					break;
				case State.Initialize:
					Initialize ();
					break;
				case State.HomeScreen:
					HomeScreen ();
					break;
				case State.Results:
					Results ();
					break;
				case State.Credits:
					Credits ();
					break;
				case State.One:
					One ();
					break;
				case State.Two:
					Two ();
					break;
				case State.Three:
					Three ();
					break;
				case State.Four:
					Four ();
					break;
				case State.Five:
					Five ();
					break;
				case State.Six:
					Six ();
					break;
				case State.Seven:
					Seven ();
					break;
				case State.Eight:
					Eight ();
					break;
				case State.Nine:
					Nine ();
					break;
				case State.Ten:
					Ten ();
					break;
				}
				yield return null;
			}
		}

		void Initialize() {
			if (_cacheLevelState != levelState) {
				speed = 0;
				Debug.Log ("Initialize");
				_cacheLevelState = levelState;
				SetState (State.One);
			}
		}

		void HomeScreen() {
			if (_cacheLevelState != levelState) {
				speed = 0;
				Debug.Log ("HomeScreen");
				_cacheLevelState = levelState;
			}
		}

		void Results() {
			if (_cacheLevelState != levelState) {
				speed = 0;
				_cacheLevelState = levelState;
			}
		}

		void Credits() {
			if (_cacheLevelState != levelState) {
				speed = 0;
				_cacheLevelState = levelState;
			}
		}

		void One() {
			if (_cacheLevelState != levelState) {
				speed = 1;
				Debug.Log ("One");
				_cacheLevelState = levelState;
				//SetState (State.Two);
			}
		}

		void Two() {
			if (_cacheLevelState != levelState) {
				speed = 2;
				Debug.Log ("Two");
				_cacheLevelState = levelState;
			}
		}

		void Three() {
			if (_cacheLevelState != levelState) {
				speed = 3;
				_cacheLevelState = levelState;
			}
		}

		void Four() {
			if (_cacheLevelState != levelState) {
				speed = 4;
				_cacheLevelState = levelState;
			}
		}

		void Five() {
			if (_cacheLevelState != levelState) {
				speed = 5;
				_cacheLevelState = levelState;
			}
		}

		void Six() {
			if (_cacheLevelState != levelState) {
				speed = 6;
				_cacheLevelState = levelState;
			}
		}

		void Seven() {
			if (_cacheLevelState != levelState) {
				speed = 7;
				_cacheLevelState = levelState;
			}
		}

		void Eight() {
			if (_cacheLevelState != levelState) {
				speed = 8;
				_cacheLevelState = levelState;
			}
		}

		void Nine() {
			if (_cacheLevelState != levelState) {
				speed = 9;
				_cacheLevelState = levelState;
			}
		}

		void Ten() {
			if (_cacheLevelState != levelState) {
				speed = 10;
				_cacheLevelState = levelState;
			}
		}

		void SetState(State newState) {
			_prevLevelState = levelState;
			_cacheLevelState = State.None;
			levelState = newState;
		}


	}
}