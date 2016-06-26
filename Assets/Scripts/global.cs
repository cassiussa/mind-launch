using UnityEngine;
using System.Collections;

namespace GlobalVariables {
	public class global : MonoBehaviour {
		public enum State { None, Initialize, HomeScreen, Results, Credits, One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten }
		public State levelState = State.None;
		//State _prevLevelState = State.None;
		public State _cacheLevelState = State.None;

		public GameObject levelOneGO;

		public GameObject[][] levelArrays = new GameObject[10][];

		public GameObject[] levelOneArray = new GameObject[20];
		public GameObject[] levelTwoArray = new GameObject[25];
		public GameObject[] levelThreeArray = new GameObject[30];
		public GameObject[] levelFourArray = new GameObject[35];
		public GameObject[] levelFiveArray = new GameObject[40];
		public GameObject[] levelSixArray = new GameObject[45];
		public GameObject[] levelSevenArray = new GameObject[50];
		public GameObject[] levelEightArray = new GameObject[60];
		public GameObject[] levelNineArray = new GameObject[75];
		public GameObject[] levelTenArray = new GameObject[100];

		public GameObject[] levelParents = new GameObject[10];

		GameObject levelOneParent;
		GameObject levelTwoParent;
		GameObject levelThreeParent;
		GameObject levelFourParent;
		GameObject levelFiveParent;
		GameObject levelSixParent;
		GameObject levelSevenParent;
		GameObject levelEightParent;
		GameObject levelNineParent;
		GameObject levelTenParent;
		
		public static float fadeTime = 3.0f;	// Used by LayerFade.cs

		public static float speed = 0f;

		void Awake () {

			levelOneParent = new GameObject("Level 1");
			levelTwoParent = new GameObject("Level 2");
			levelThreeParent = new GameObject("Level 3");
			levelFourParent = new GameObject("Level 4");
			levelFiveParent = new GameObject("Level 5");
			levelSixParent = new GameObject("Level 6");
			levelSevenParent = new GameObject("Level 7");
			levelEightParent = new GameObject("Level 8");
			levelNineParent = new GameObject("Level 9");
			levelTenParent = new GameObject("Level 10");

			levelParents [0] = levelOneParent;
			levelParents [1] = levelTwoParent;
			levelParents [2] = levelThreeParent;
			levelParents [3] = levelFourParent;
			levelParents [4] = levelFiveParent;
			levelParents [5] = levelSixParent;
			levelParents [6] = levelSevenParent;
			levelParents [7] = levelEightParent;
			levelParents [8] = levelNineParent;
			levelParents [9] = levelTenParent;

			levelArrays[0] = levelOneArray;
			levelArrays[1] = levelTwoArray;
			levelArrays[2] = levelThreeArray;
			levelArrays[3] = levelFourArray;
			levelArrays[4] = levelFiveArray;
			levelArrays[5] = levelSixArray;
			levelArrays[6] = levelSevenArray;
			levelArrays[7] = levelEightArray;
			levelArrays[8] = levelNineArray;
			levelArrays[9] = levelTenArray;
			// Set the initial state to Initialize so that it can gather the details about game state and apply them to this layer's motion
			SetState (State.Initialize);

			for (int i=0;i<levelArrays.Length;i++) {
				for(int a=0;a<levelArrays[i].Length;a++) {
					//print ("generating ARR #"+i+", GO #"+a);
					levelArrays[i][a] = (GameObject)Instantiate(levelOneGO, new Vector3(0f,0f,(10+(a*5))), Quaternion.identity);
					levelArrays[i][a].name = "Shape Layer "+(a+1);
					levelArrays[i][a].transform.parent = levelParents[i].transform;
				}
			}
		}

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
				for(int i=0;i<levelParents.Length;i++) {
					if(levelParents[i] != levelOneParent) {
						levelParents[i].SetActive(false);
					} else {
						levelParents[i].SetActive(true);

					}
				}
				global.fadeTime = 3f;
				Debug.Log ("One");
				_cacheLevelState = levelState;
				//SetState (State.Two);
			}
		}

		void Two() {
			if (_cacheLevelState != levelState) {
				speed = 2;
				for(int i=0;i<levelParents.Length;i++) {
					if(levelParents[i] != levelTwoParent)
						levelParents[i].SetActive(false);
					else
						levelParents[i].SetActive(true);
				}
				global.fadeTime = 2.5f;
				Debug.Log ("Two");
				_cacheLevelState = levelState;
			}
		}

		void Three() {
			if (_cacheLevelState != levelState) {
				speed = 3;
				for(int i=0;i<levelParents.Length;i++) {
					if(levelParents[i] != levelThreeParent)
						levelParents[i].SetActive(false);
					else
						levelParents[i].SetActive(true);
				}
				global.fadeTime = 2f;
				_cacheLevelState = levelState;
			}
		}

		void Four() {
			if (_cacheLevelState != levelState) {
				speed = 4;
				for(int i=0;i<levelParents.Length;i++) {
					if(levelParents[i] != levelFourParent)
						levelParents[i].SetActive(false);
					else
						levelParents[i].SetActive(true);
				}
				global.fadeTime = 1.5f;
				_cacheLevelState = levelState;
			}
		}

		void Five() {
			if (_cacheLevelState != levelState) {
				speed = 5;
				for(int i=0;i<levelParents.Length;i++) {
					if(levelParents[i] != levelFiveParent)
						levelParents[i].SetActive(false);
					else
						levelParents[i].SetActive(true);
				}
				global.fadeTime = 1f;
				_cacheLevelState = levelState;
			}
		}

		void Six() {
			if (_cacheLevelState != levelState) {
				speed = 6;
				for(int i=0;i<levelParents.Length;i++) {
					if(levelParents[i] != levelSixParent)
						levelParents[i].SetActive(false);
					else
						levelParents[i].SetActive(true);
				}
				global.fadeTime = 0.75f;
				_cacheLevelState = levelState;
			}
		}

		void Seven() {
			if (_cacheLevelState != levelState) {
				speed = 7;
				for(int i=0;i<levelParents.Length;i++) {
					if(levelParents[i] != levelSevenParent)
						levelParents[i].SetActive(false);
					else
						levelParents[i].SetActive(true);
				}
				global.fadeTime = 0.5f;
				_cacheLevelState = levelState;
			}
		}

		void Eight() {
			if (_cacheLevelState != levelState) {
				speed = 8;
				for(int i=0;i<levelParents.Length;i++) {
					if(levelParents[i] != levelEightParent)
						levelParents[i].SetActive(false);
					else
						levelParents[i].SetActive(true);
				}
				global.fadeTime = 0.4f;
				_cacheLevelState = levelState;
			}
		}

		void Nine() {
			if (_cacheLevelState != levelState) {
				speed = 9;
				for(int i=0;i<levelParents.Length;i++) {
					if(levelParents[i] != levelNineParent)
						levelParents[i].SetActive(false);
					else
						levelParents[i].SetActive(true);
				}
				global.fadeTime = 0.3f;
				_cacheLevelState = levelState;
			}
		}

		void Ten() {
			if (_cacheLevelState != levelState) {
				speed = 10;
				for(int i=0;i<levelParents.Length;i++) {
					if(levelParents[i] != levelTenParent)
						levelParents[i].SetActive(false);
					else
						levelParents[i].SetActive(true);
				}
				global.fadeTime = 0.25f;
				_cacheLevelState = levelState;
			}
		}

		void SetState(State newState) {
			//_prevLevelState = levelState;
			_cacheLevelState = State.None;
			levelState = newState;
		}


	}
}