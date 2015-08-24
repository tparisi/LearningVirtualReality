using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider))]
public class PanoItem : MonoBehaviour {

	public GameObject pano = null;
	public int index = 0;

	// Use this for initialization
	void Start () {
	
		SetGazedAt(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetGazedAt(bool gazedAt) {
		Debug.Log("in SetGazedAt " + (gazedAt ? "true" : "false"));

		Renderer renderer = GetComponent<Renderer>();
		Color color = renderer.material.color;
		color.a = gazedAt ? 1f : 0.5f;
		/*
		if (gazedAt) {
			color.b = color.g = 0f;
		}
		else {
			color.r = color.b = color.g = 1f;
		}
		*/
		renderer.material.color = color;

	}

	public void OnClick() {
		/*
		Debug.Log("in onClick");
		*/

		Renderer renderer = GetComponent<Renderer>();

		var panoRenderer = pano.GetComponent<Renderer>();
		Texture tex = renderer.materials[0].GetTexture("_MainTex");
		panoRenderer.materials[0].SetTexture("_MainTex", tex);
	}

}
