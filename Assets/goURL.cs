using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goURL : MonoBehaviour
{
	public static string productName;
    public void onLogoClick() {
        Application.OpenURL("https://general.futuregenerali.in");
    }
	
	public void OnClickHealth(){
		   productName="HealthProducts";
		   SceneManager.LoadScene(4);	
	}
	public void BuyNow(){
		    productName="Footwears";
		   SceneManager.LoadScene(4);   
	}
	public void DemoFVideo(){
		Application.OpenURL("https://www.youtube.com/watch?v=HHflh79N8Ss");
	}
	public void DemoAmex(){
		Application.OpenURL("https://youtu.be/K-h6BM6g-MY");
	}
	public void AmexWebsite(){
		Application.OpenURL("https://global.americanexpress.com/acq/intl/dpa/japa/ind/pers/begin.do?perform=IntlEapp%3AIND%3Amembershiprewards_credit&feePay=P10&intlink=in-acq-allcards-eapply");
	}
	public void BuyCancer(){
		Application.OpenURL("https://buyonline.life.futuregenerali.in/cancer-protect-insurance/Application/CancerCareHomePage.aspx?Mode=Online&_ga=2.200189997.2064621237.1551499084-723058327.1550737455");
	}
	public void ReviewFrooti(){
		Application.OpenURL("https://www.youtube.com/watch?v=IL8nIK1unw8");
	}

}
