using UnityEngine;
using System.Collections;

public class RenderManager : MonoBehaviour {

	void Start(){	
		for (int i = 0; i < gameObject.GetComponent<Renderer>().materials.Length; i++) {
			gameObject.GetComponent<Renderer>().materials[i].renderQueue = 2002;
		}
	}
}
