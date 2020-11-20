using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Proyecto26;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
public class getDiscount : MonoBehaviour
{

	public static string emailstring;
	public static string feedstring;
	public static string genderstring;
	public static string agestring;
	public static string phonestring;
	public Text status;
	public InputField emailID;
	public InputField feedBack;
	public InputField gender;
	public InputField age;
	public InputField phone;
    // Start is called before the first frame update
  
	
	public void OnSubmit(){
	emailstring=emailID.text;
	feedstring=feedBack.text;
	genderstring=gender.text;
	agestring=age.text;
	phonestring=phone.text;
	if(emailstring==""||feedstring==""||genderstring==""||agestring==""||phonestring=="")
	status.text="Requires all data to be filled";
	else
	postToDatabase();
	}
	
	public void postToDatabase()
	{
	UserFeedback userFeed = new UserFeedback();
	if(goURL.productName=="Footwears")
		{
		RestClient.Post("https://amexar-cb8bc.firebaseio.com/Reebok/.json",userFeed);
		status.text="Feedback Submitted";
		SceneManager.LoadScene(1);
		}
	if(goURL.productName=="HealthProducts")
		{
		RestClient.Post("https://amexar-cb8bc.firebaseio.com/JunkFoods/.json",userFeed);
		status.text="Feedback Submitted";
		SceneManager.LoadScene(1);
		}
	}
	
	public void OnLoadScene(int changeScene){
	 SceneManager.LoadScene(changeScene);
	}

  
}
