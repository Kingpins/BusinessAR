using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
[Serializable]
public class UserFeedback
{
   public string userEmail;
   public string userFeedback;
   public string userGender;
   public string userAge;
   public string userPhone;
   
   public UserFeedback(){
   	userEmail=getDiscount.emailstring;
	userFeedback=getDiscount.feedstring;
	userGender=getDiscount.genderstring;
	userAge=getDiscount.agestring;
	userPhone=getDiscount.phonestring;
	
   }
}
