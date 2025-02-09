using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sharp.Mods
{
    internal class Sound
    {
        static void PlaySound(int soundId, bool leftHanded, float Volume)
        {
            if (PhotonNetwork.InRoom)
            {
                GorillaTagger.Instance.myVRRig.SendRPC("RPC_PlayHandTap", RpcTarget.All, new object[]
                {
                    soundId,
                    leftHanded,
                    Volume
                });
                Safety.FlushRPCS();
            };
        }

        public static void ButtonSpam()
        {
            if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.6f)
            {
                PlaySound(67, false, 3f);
            }
        }
        public static void KeyboardSpam()
        {
            if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.6f)
            {
                PlaySound(66, false, 3f);
            }
        }
        public static void MetalSpam()
        {
            if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.6f)
            {
                PlaySound(18, false, 3f);
            }
        }
        public static void CrystalSpam()
        {
            if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.6f)
            {
                PlaySound(23, false, 3f);
            }
        }
        public static void IceSpam()
        {
            if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.6f)
            {
                PlaySound(61, false, 3f);
            }
        }
        public static void CymbolSpam()
        {
            if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.6f)
            {
                PlaySound(72, false, 3f);
            }
        }
        public static void PopSpam()
        {
            if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.6f)
            {
                PlaySound(84, false, 3f);
            }
        }
        public static void TurkeySpam()
        {
            if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.6f)
            {
                PlaySound(83, false, 3f);
            }
        }

        public static void BiteSpam()
        {
            if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.6f)
            {
                PlaySound(85, false, 3f);
            }
        }

        public static void DrumGiant()
        {
            if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.6f)
            {
                PlaySound(68, false, 3f);
            }
        }
        public static void WebTouch()
        {
            if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.6f)
            {
                PlaySound(82, false, 3f);
            }
        }
    }
}
