using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Facebook.Unity;

public class FacebookScript : MonoBehaviour
{
    public GameObject Lin;
    public GameObject Lout;
    public GameObject Usn;
    public GameObject Pfp;

    void Awake()
       {
        FacebookManager.Instance.InitFB();
        DealWithFBMenus(FB.IsLoggedIn);
    }

    public void FBlogin()
    {
        List<string> permissions = new List<string> ();
        permissions.Add ("public_profile");

        FB.LogInWithReadPermissions(permissions, AuthCallBack);
    }

    void AuthCallBack(IResult result)
    {
        if(result.Error != null)
        {
             Debug.Log (result.Error);
        } 
        else 
        {
            if(FB.IsLoggedIn)
            {
                FacebookManager.Instance.IsLoggedIn = true;
                FacebookManager.Instance.GetProfile();
                Debug.Log("FB is logged in");
            } 
            else 
            {
                Debug.Log("FB is not logged in");
            }
            DealWithFBMenus(FB.IsLoggedIn);
        }
    }
   
   void DealWithFBMenus( bool IsLoggedIn)
   {
       if (IsLoggedIn)
       {
           Lin.SetActive (true);
           Lout.SetActive (false);
           
            if(FacebookManager.Instance.ProfileName != null)
            {
                Text UserName = Usn.GetComponent<Text>();
                UserName.text = "" + FacebookManager.Instance.ProfileName;
            }
            else
            {
                StartCoroutine("WaitForProfileName");
            }
            if (FacebookManager.Instance.ProfilePic != null)
            {
                Image ProfilePic = Pfp.GetComponent<Image>();
                ProfilePic.sprite = FacebookManager.Instance.ProfilePic;
            }
            else
            {
                StartCoroutine("WaitForProfilePic");
            }
        }
       else 
       {
           Lin.SetActive (false);
           Lout.SetActive (true);
       }
   }
    IEnumerator WaitForProfileName()
    {
        while(FacebookManager.Instance.ProfileName == null)
        {
            yield return null;
        }
        DealWithFBMenus (FB.IsLoggedIn);
    }
    IEnumerator WaitForProfilePic()
    {
        while (FacebookManager.Instance.ProfilePic == null)
        {
            yield return null;
        }
        DealWithFBMenus(FB.IsLoggedIn);
    }

    public void Share()
    {
        FacebookManager.Instance.Share();
    }

}