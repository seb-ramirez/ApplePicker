using UnityEngine;
using System.Collections;

public class Apple : MonoBehaviour {

	public static float 	bottomY = -20f;

	void Update () {
		if ( transform.position.y < bottomY ) {
			Destroy (this.gameObject);

			//get a reference to the applepicker component of the main camera
			ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
			// call the public appledestroyed() method of apscript
			apScript.AppleDestroyed();
		}
	}
}
