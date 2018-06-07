using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeTeamName : MonoBehaviour {

	public GameObject changenamepanelred;
	public GameObject changenamepanelblue;

	public Text redteamName;
	public Text blueteamName;

	public InputField redIF;
	public InputField blueIF;

	public static string redName;
	public static string blueName;


	// Use this for initialization
	void Start () {
	changenamepanelred.SetActive(false);
	changenamepanelred.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		redName = redteamName.text;
		blueName = blueteamName.text;
	}

	public void onChangeRedNameClick() {
	changenamepanelred.SetActive(true);
	}

	public void onRedConfirmClick() {
	string teamName;
	teamName = redIF.text.ToString();
	redteamName.text = teamName;
	changenamepanelred.SetActive(false);
	}

	public void onChangeBlueNameClick() {
	changenamepanelblue.SetActive(true);
	}

	public void onBlueConfirmClick() {
	string teamName;
	teamName = blueIF.text.ToString();
	blueteamName.text = teamName;
	changenamepanelblue.SetActive(false);
	}
}
