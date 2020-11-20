using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Proyecto26;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
public class feedback : MonoBehaviour
{

	public static string emailstring;
	public static string feedstring;
	public static string genderstring;
	public static string agestring;
	public Text status;
	public InputField emailID;
	public InputField feedBack;

    // Start is called before the first frame update
  
	
	public void OnSubmit(){
	emailstring=emailID.text;
	feedstring=feedBack.text;

	if(emailstring==""||feedstring=="")
	status.text="Requires all data to be filled";
	else
	postToDatabase();
	}
	
	public void postToDatabase()
	{
	UserFeedback1 userFeed = new UserFeedback1();
	RestClient.Post("https://amexar-ccb8bc.firebaseio.com/GeneralFeedbacks/.json",userFeed);
	status.text="Feedback Submitted";
	SceneManager.LoadScene(0);
	}
	
	public void OnLoadScene(int changeScene){
	 SceneManager.LoadScene(changeScene);
	}

  
}
