using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour {


	[SerializeField] int redScore;
	[SerializeField] int blueScore;
	[SerializeField] int redMaxscore;
	[SerializeField] int blueMaxscore;
	[SerializeField] int redSetWon;
	[SerializeField] int blueSetWon;
	[SerializeField] int minusred;
	[SerializeField] int minusblue;
	[SerializeField] int gamePlayed;

	[SerializeField] bool whoWon;
	[SerializeField] bool suddendead;
	[SerializeField] bool dew;

	public GameObject finalScorePanel;

	public Text redScoreText;
	public Text blueScoreText;

	public Text game1Score;
	public Text game2Score;
	public Text game3Score;
	public Text game4Score;
	public Text game5Score;

	public Text endgame1Score;
	public Text endgame2Score;
	public Text endgame3Score;
	public Text endgame4Score;
	public Text endgame5Score;

	public Text whoWonText;

	public AudioClip MusicClip;
	public AudioSource source;

	// Default Score
	void Start () {

		source.clip = MusicClip;

		finalScorePanel.SetActive(false);
		suddendead = false;
		dew = false;
		gamePlayed = 0;
		redScore = 0;
		blueScore = 0;
		redSetWon = 0;
		blueSetWon = 0;
		redMaxscore = 25;
		blueMaxscore = 25;

	}
	
	// Update is called once per frame
	void Update () {

		redScoreText.text = redScore.ToString();
		blueScoreText.text = blueScore.ToString();

		if(redSetWon == 3 || blueSetWon == 3) {
		finalizeScore();
		}


		if(gamePlayed == 5) {
			finalizeScore();
		}

		if(dew == true) {
			minusred = redScore - blueScore;
			minusblue = blueScore - redScore;
			if (minusred == 2) {
					redteamWon();
			}
			if (minusblue == 2) {
					blueteamWon();
			}
		}

		if(redSetWon == 2 && blueSetWon == 2 && blueSetWon == redSetWon) {
			suddendead = true;
		}

		if(suddendead == true) {
			redMaxscore = 15;
			blueMaxscore = 15;

			if(redScore >= 14 && blueScore >= 14 && redScore == blueScore) { 
				dew = true;
			}

			if(dew == false) {

				if(redScore >= redMaxscore) {
				redteamWon();
			}

			///////////////////////////////////////////////////////

			if(blueScore >= blueMaxscore) {
				blueteamWon();
			}

			}


		}

		if(suddendead == false) {
			if(redScore >= 24 && blueScore >= 24 && redScore == blueScore) { 
				dew = true;
			}


			////////////////////////////////////////////////////////
			
			if(redScore >= redMaxscore) {
				redteamWon();
			}

			///////////////////////////////////////////////////////

			if(blueScore >= blueMaxscore) {
				blueteamWon();
			}
		}


	}

	public void redteamWon() {
					
					redSetWon++;
					whoWon = true;
					gamePlayed++;
					Debug.Log(whoWon);
					suddendead = false;
					dew = false;
					redMaxscore = 25;
					blueMaxscore = 25;
					finishSet();
					redScore = 0;
					blueScore = 0;
	}

	public void blueteamWon() {

					blueSetWon++;
					whoWon = false;
					gamePlayed++;
					Debug.Log(whoWon);
					suddendead = false;
					dew = false;
					redMaxscore = 25;
					blueMaxscore = 25;
					finishSet();
					redScore = 0;
					blueScore = 0;
	}

	public void onRedScoreClick() {

		if(suddendead == false) {
			if (dew == true) {
				if(redScore == blueScore || redScore == blueScore + 1 || blueScore == redScore + 1) {
					redMaxscore++;
					blueMaxscore++;
				}
			}

		}

		if(suddendead == true) {
			if (dew == true) {
				if(redScore == blueScore || redScore == blueScore + 1 || blueScore == redScore + 1) {
					redMaxscore++;
					blueMaxscore++;
				}
			}

		}


		redScore++;
		IsServing.staticarrow = "<";

	}

	public void onBlueScoreClick() {

		if(suddendead == false) {
			if (dew == true) {
				if(redScore == blueScore || redScore == blueScore + 1 || blueScore == redScore + 1) {
					redMaxscore++;
					blueMaxscore++;
				}
			}

		}

		if(suddendead == true) {
			if (dew == true) {
				if(redScore == blueScore || redScore == blueScore + 1 || blueScore == redScore + 1) {
					redMaxscore++;
					blueMaxscore++;
				}
			}

		}

		blueScore++;
		IsServing.staticarrow = ">";
	}

	public void finishSet(){

		source.Play();

		switch(gamePlayed) {
			case 1:
				if(whoWon == true) {
					game1Score.text = redScore.ToString();
					game1Score.color = Color.red;

					endgame1Score.text = redScore.ToString();
					endgame1Score.color = Color.red;
				}
				else {
					game1Score.text = blueScore.ToString();
					game1Score.color = Color.blue;

					endgame1Score.text = blueScore.ToString();
					endgame1Score.color = Color.blue;
				}
			break;

			case 2:
				if(whoWon == true) {
					game2Score.text = redScore.ToString();
					game2Score.color = Color.red;

					endgame2Score.text = redScore.ToString();
					endgame2Score.color = Color.red;

				}
				else {
					game2Score.text = blueScore.ToString();
					game2Score.color = Color.blue;

					endgame2Score.text = blueScore.ToString();
					endgame2Score.color = Color.blue;
				}
			break;

			case 3:
				if(whoWon == true) {
					game3Score.text = redScore.ToString();
					game3Score.color = Color.red;

					endgame3Score.text = redScore.ToString();
					endgame3Score.color = Color.red;
				}
				else {
					game3Score.text = blueScore.ToString();
					game3Score.color = Color.blue;

					endgame3Score.text = blueScore.ToString();
					endgame3Score.color = Color.blue;
				}
			break;

			case 4:
				if(whoWon == true) {
					game4Score.text = redScore.ToString();
					game4Score.color = Color.red;

					endgame4Score.text = redScore.ToString();
					endgame4Score.color = Color.red;
				}
				else {
					game4Score.text = blueScore.ToString();
					game4Score.color = Color.blue;

					endgame4Score.text = blueScore.ToString();
					endgame4Score.color = Color.blue;
				}
			break;

			case 5:
				if(whoWon == true) {
					game5Score.text = redScore.ToString();
					game5Score.color = Color.red;

					endgame5Score.text = redScore.ToString();
					endgame5Score.color = Color.red;
				}
				else {
					game5Score.text = blueScore.ToString();
					game5Score.color = Color.blue;

					endgame5Score.text = blueScore.ToString();
					endgame5Score.color = Color.blue;
				}
			break;

		}

	}

	public void resetEverything() {
		redScore = 0;
		blueScore = 0;
		redMaxscore = 25;
		blueMaxscore = 25;
		redSetWon = 0;
		blueSetWon = 0;
		gamePlayed = 0;
		suddendead = false;
		dew = false;

	}

	public void finalizeScore() {

		if (redSetWon > blueSetWon) {
			whoWonText.text = ChangeTeamName.redName + " Won!!!!";
			whoWonText.color = Color.red;
		}

		if (blueSetWon > redSetWon) {
			whoWonText.text = ChangeTeamName.blueName + " Won!!!!";
			whoWonText.color = Color.blue;
		}

		finalScorePanel.SetActive(true);

	}

	public void restartGame() {
		SceneManager.LoadScene("Scene");
	}

	public void checkscoreClick() {
		Debug.ClearDeveloperConsole();
		Debug.Log(redMaxscore);
		Debug.Log(blueMaxscore);
		Debug.Log(dew);
		Debug.Log(minusred);
		Debug.Log(minusblue);
		Debug.Log(ChangeTeamName.blueName);
	}

	public void onQuitClick() {
		Application.Quit();
	}
}
