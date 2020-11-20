using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	void Update(){
	 if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
	}
	public void OnExit(){
	Application.Quit();
	}
	public void OnLoadScene(int changeScene){
	 SceneManager.LoadScene(changeScene);
	}
	public void instaLink(){
	Application.OpenURL("https://www.instagram.com/americanexpress/");
	}
	public void facebookLink(){
	Application.OpenURL("https://www.facebook.com/americanexpress");
	}

	public void twitterLink(){
	Application.OpenURL("https://twitter.com/Future_Generali");
	}
	public void linkedLink(){
	Application.OpenURL("https://in.linkedin.com/company/american-express");
	}

	public void youtubeLink(){
	Application.OpenURL("https://www.youtube.com/user/AmericanExpress/featured");
	}
}
