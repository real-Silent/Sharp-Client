using GorillaNetworking;
using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;
using static Mono.Security.X509.X520;

namespace Sharp.Mods
{
    internal class Room
    {
        public static void Rejoin()
        {
            string name = PhotonNetwork.CurrentRoom.Name;
            PhotonNetwork.Disconnect();
            PhotonNetworkController.Instance.AttemptToJoinSpecificRoom(name, JoinType.Solo);
        }
        public static void Daisy09()
        {
            PhotonNetworkController.Instance.AttemptToJoinSpecificRoom("DAISY09", JoinType.Solo);
        }

        public static void Pbbv()
        {
            PhotonNetworkController.Instance.AttemptToJoinSpecificRoom("PBBV", JoinType.Solo);
        }
        public static void Mod()
        {
            PhotonNetworkController.Instance.AttemptToJoinSpecificRoom("MOD", JoinType.Solo);
        }
        public static void Echo()
        {
            PhotonNetworkController.Instance.AttemptToJoinSpecificRoom("ECHO", JoinType.Solo);
        }
        public static void Mods()
        {
            PhotonNetworkController.Instance.AttemptToJoinSpecificRoom("MODS", JoinType.Solo);
        }
        public static void Statue()
        {
            PhotonNetworkController.Instance.AttemptToJoinSpecificRoom("STATUE", JoinType.Solo);
        }
        public static void J3vu()
        {
            PhotonNetworkController.Instance.AttemptToJoinSpecificRoom("J3VU", JoinType.Solo);
        }
        public static void BanShee()
        {
            PhotonNetworkController.Instance.AttemptToJoinSpecificRoom("BANSHEE", JoinType.Solo);
        }
        public static void Spider()
        {
            PhotonNetworkController.Instance.AttemptToJoinSpecificRoom("SPIDER", JoinType.Solo);
        }
    }
}
