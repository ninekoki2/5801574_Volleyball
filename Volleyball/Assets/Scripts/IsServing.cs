using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IsServing : MonoBehaviour {

	public static string staticarrow;
	public Text arrowtext;

	// Use this for initialization
	void Start () {
		staticarrow = "";
		arrowtext.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		arrowtext.text = staticarrow.ToString();
	}
}
