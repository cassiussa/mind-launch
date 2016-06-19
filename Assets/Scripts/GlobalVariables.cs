using UnityEngine;
using System.Collections;

namespace GlobalVariables {
	public class global : MonoBehaviour {
		public enum State { None, Initialize, HomeScreen, Results, Credits, One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten }
		public static State level = State.None;
		State _prevLevelState = State.None;
		public State _cacheLevelState = State.None;

		//public static int level = 1;
		public static float speed = 0f;
	}
}