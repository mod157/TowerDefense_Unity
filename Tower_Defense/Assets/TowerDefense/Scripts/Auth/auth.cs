
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.Networking;
    using System.Text;
    using UnityEngine.SceneManagement;
    
    namespace TowerDefenseAuth
{
    public class auth : MonoBehaviour{
/*
        public int GameID;
        public string PlatformID;
        public string email;
        public string password;
        public Firebase.Auth.FirebaseUser FirebaseUser;

        public void SignUp() {
            Firebase.Auth.FirebaseAuth firbaseAuth = Firebase.Auth.FirebaseAuth.DefaultInstance;
            firbaseAuth.CreateUserWithEmailAndPasswordAsync(email, password).ContinueWith(task => {
            if (task.IsCanceled) {
                Debug.LogError("CreateUserWithEmailAndPasswordAsync was canceled.");
                return;
            }
            if (task.IsFaulted) {
                Debug.LogError("CreateUserWithEmailAndPasswordAsync encountered an error: " + task.Exception);
                return; 
            }
            // Firebase user has been created.
            FirebaseUser = task.Result;
            Debug.LogFormat("Firebase user created successfully: {0} ({1})",
                FirebaseUser.DisplayName, FirebaseUser.UserId);
            });
        }

        public void SignIn() {
            Firebase.Auth.FirebaseAuth firbaseAuth = Firebase.Auth.FirebaseAuth.DefaultInstance;
            firbaseAuth.SignInWithEmailAndPasswordAsync(email, password).ContinueWith(task => {
            if (task.IsCanceled) {
                Debug.LogError("SignInWithEmailAndPasswordAsync was canceled.");
                return ;
            }
            if (task.IsFaulted) {
                Debug.LogError("SignInWithEmailAndPasswordAsync encountered an error: " + task.Exception);
                return ;
            }
            FirebaseUser = task.Result;
            Debug.LogFormat("User signed in successfully: {0}", FirebaseUser.UserId);
            PlatformID = FirebaseUser.UserId;
            });
        }

        public IEnumerator GetGameID() {
            Debug.Log("call get GameId");
            Debug.Log(FirebaseUser.UserId);
            string data = "{'platform_id':'" + PlatformID + "','platform':'google','device_id':'" + SystemInfo.deviceUniqueIdentifier + "'}";
            UnityWebRequest webRequest = UnityWebRequest.Post("http://3.36.40.68:8888/login", data);
            webRequest.uploadHandler = new UploadHandlerRaw(Encoding.UTF8.GetBytes(data));
            webRequest.SetRequestHeader("Content-Type", "application/json");
            yield return webRequest.SendWebRequest();
            if(webRequest.isNetworkError || webRequest.isHttpError) {
                Debug.Log(webRequest.error);
            } else {
                GameID = 1;
                Debug.Log(webRequest.downloadHandler.text);
                Debug.Log("login complete! ");
            }
        }*/
    }

}
