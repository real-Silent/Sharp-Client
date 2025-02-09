using GorillaNetworking;
using Photon.Pun;
using StupidTemplate.Notifications;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Sharp.Mods
{
    internal class Safety
    {
        public static void FlushRPCS()
        {
            PhotonNetwork.MaxResendsBeforeDisconnect = int.MaxValue;
            PhotonNetwork.QuickResends = int.MaxValue;
            PhotonNetwork.OpCleanActorRpcBuffer(PhotonNetwork.LocalPlayer.ActorNumber);
            PhotonNetwork.SendAllOutgoingCommands();

            GorillaNot.instance.logErrorMax = int.MaxValue;
            GorillaNot.instance.rpcErrorMax = int.MaxValue;
            GorillaNot.instance.rpcCallLimit = int.MaxValue;
            GorillaNot.instance.OnPlayerLeftRoom(PhotonNetwork.LocalPlayer);
        }
        public static void AntiReport(bool dis, bool jrrgc)
        {
            try
            {
                foreach (GorillaPlayerScoreboardLine line in GorillaScoreboardTotalUpdater.allScoreboardLines)
                {
                    if (line.linePlayer == NetworkSystem.Instance.LocalPlayer)
                    {
                        Transform thing = line.reportButton.gameObject.transform;
                        foreach (VRRig rig in GorillaParent.instance.vrrigs)
                        {
                            if (rig != GorillaTagger.Instance.offlineVRRig)
                            {
                                float righthand = Vector3.Distance(rig.rightHandTransform.position, thing.position);
                                float lefthand = Vector3.Distance(rig.rightHandTransform.position, thing.position);

                                if (righthand < 0.75f || lefthand < 0.75f)
                                {
                                    if (dis)
                                    {
                                        PhotonNetwork.Disconnect();
                                    }
                                    if (jrrgc)
                                    {
                                        string[] codes = { "SREN17", "SREN18", "DAISY09", "PBBV", "J3VU", "BANSHEE", "ECHO", "SPIDER" };
                                        int rand = UnityEngine.Random.Range(0, codes.Length);
                                        PhotonNetwork.Disconnect();
                                        PhotonNetworkController.Instance.AttemptToJoinSpecificRoom(codes[rand], JoinType.Solo);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch { }
        }

        public static void NoFinger()
        {
            ControllerInputPoller.instance.rightControllerIndexFloat = 0;
            ControllerInputPoller.instance.leftControllerIndexFloat = 0;
            ControllerInputPoller.instance.leftControllerGripFloat = 0;
            ControllerInputPoller.instance.rightControllerGripFloat = 0;
            ControllerInputPoller.instance.rightGrab = false;
            ControllerInputPoller.instance.leftGrab = false;
            ControllerInputPoller.instance.rightControllerSecondaryButton = false;
            ControllerInputPoller.instance.rightControllerSecondaryButtonTouch = false;
            ControllerInputPoller.instance.leftControllerSecondaryButton = false;
            ControllerInputPoller.instance.leftControllerSecondaryButtonTouch = false;
            ControllerInputPoller.instance.rightControllerPrimaryButton = false;
            ControllerInputPoller.instance.rightControllerPrimaryButtonTouch = false;
            ControllerInputPoller.instance.leftControllerPrimaryButton = false;
            ControllerInputPoller.instance.leftControllerPrimaryButtonTouch = false;
        }
    }
}
