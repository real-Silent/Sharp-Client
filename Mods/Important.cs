using GorillaNetworking;
using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using TMPro;
using UnityEngine;

namespace Sharp.Mods
{
    internal class Important
    {
        public static void RoomData()
        {
            string basePath = @"C:\Program Files (x86)\Steam\steamapps\common\Gorilla Tag\SharpClient";
            Directory.CreateDirectory(basePath); 
            string filePath = Path.Combine(basePath, "RoomData_" + PhotonNetwork.CurrentRoom.Name + "_Sharp.txt");
            string text = "RoomName: " + PhotonNetwork.CurrentRoom.Name +
                          "\nPlayerCount: " + PhotonNetwork.CurrentRoom.PlayerCount +
                          "\nMasterClient: " + PhotonNetwork.MasterClient +
                          "\nPlayerNames: ";
            foreach (Photon.Realtime.Player player in PhotonNetwork.CurrentRoom.Players.Values)
            {
                text += player.NickName + " [" + player.UserId + "], ";
            }
            text = text.TrimEnd(',', ' ');
            File.WriteAllText(filePath, text);
            Process.Start("notepad.exe", filePath);
        }

        public static void Mods(bool leave, bool quitgame, bool codeSHARP, bool discord)
        {
            if (leave)
            {
                PhotonNetwork.Disconnect();
            }
            if (quitgame)
            {
                Application.Quit();
            }
            if (codeSHARP)
            {
                PhotonNetworkController.Instance.AttemptToJoinSpecificRoom("SHARP CLIENT", JoinType.Solo);
            }
            if (discord)
            {
                Process.Start("https://discord.gg/R38aEdqW8e"); 
            }
        }

        static string orignalCOC = GameObject.Find("COC Text").GetComponent<TextMeshPro>().text;
        static string orignalMOTD = GameObject.Find("motdtext").GetComponent<TextMeshPro>().text;
        public static void Boards(bool on, bool off)
        {
            if (on)
            {
                GameObject.Find("COC Text").GetComponent<TextMeshPro>().text = "THANK YOU FOR USING SHARP CLIENT\nTHIS MENU IS VERY GOOD SO FAR AND WILL CONTINUE TO GET BETTER\nIF YOU WANT TO REPORT BUGS JOIN THE DISCORD\n\nIF ANYTHING LOOKS SKIDDED LET US KNOW AND I WILL REMOVE IT AND MAKE THE MOD MYSELF\n\n\nHAVE FUN!";
                GameObject.Find("motdtext").GetComponent<TextMeshPro>().text = "THANKK YOU FOR USING SHARP CLIENT THIS MENU CURRENTLY <color=yellow>UNDETECTED</color>\n\nTHIS MENU WILL BE GETTING UPDATED FREQUENTLY AS MORE GTAG UPDATES GO OUT\n\nJOIN THE DISCORD - [ discord.gg/R38aEdqW8e ]\nMAKE SURE TO READ THE COC TEXT.\n\nHAVE FUN USING SHARP CLIENT!";
                GameObject.Find("CodeOfConduct").GetComponent<TextMeshPro>().text = "SHARP CLIENT";
                GameObject.Find("motd (1)").GetComponent<TextMeshPro>().text = "SHARP CLIENT";
            }
            if (off)
            {
                GameObject.Find("COC Text").GetComponent<TextMeshPro>().text = orignalCOC;
                GameObject.Find("CodeOfConduct").GetComponent<TextMeshPro>().text = "GORILLA CODE OF CONDUCT";
                GameObject.Find("motdtext").GetComponent<TextMeshPro>().text = orignalMOTD;
                GameObject.Find("motd (1)").GetComponent<TextMeshPro>().text = "MESSAGE OF THE DAY";
            }
        }
    }
}
