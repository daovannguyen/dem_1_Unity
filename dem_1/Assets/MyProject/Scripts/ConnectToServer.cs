using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
using Photon.Realtime;
using UnityEngine.SceneManagement;


public class ConnectToServer : MonoBehaviourPunCallbacks
{
    public InputField usernameInputField;
    public Text joinButtonText;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickConnect()
    {
        if (usernameInputField.text.Length >= 1)
        {
            PhotonNetwork.NickName = usernameInputField.text;
            joinButtonText.text = "Connecting...";
            PhotonNetwork.ConnectUsingSettings();
        }
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Conneted!");
        SceneManager.LoadScene("Lobby");
    }

}
