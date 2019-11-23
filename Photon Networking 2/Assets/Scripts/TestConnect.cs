﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class TestConnect : MonoBehaviourPunCallbacks
{
    // Start is called before the first frame update
    void Start()
    {
        print("connecting to server");

        PhotonNetwork.NickName = MasterManager.GameSettings.NickName;
        PhotonNetwork.GameVersion = MasterManager.GameSettings.GameVersion;
        PhotonNetwork.ConnectUsingSettings();
       



    }

    public override void OnConnectedToMaster()
    {
        print("Connected to master");
        print(PhotonNetwork.LocalPlayer.NickName);
    }


    public override void OnDisconnected(DisconnectCause cause)
    {
        print("Disconnected from server for reason" + cause.ToString());


    }





}
