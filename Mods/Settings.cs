using StupidTemplate.Classes;
using StupidTemplate.Menu;
using StupidTemplate.Notifications;
using UnityEngine;
using static StupidTemplate.Menu.Main;
using static StupidTemplate.Settings;

namespace StupidTemplate.Mods
{
    internal class SettingsMods
    {
        public static void EnterSettings()
        {
            buttonsType = 1;
            pageNumber = 0;
        }

        public static void Movement()
        {
            buttonsType = 2;
            pageNumber = 0;
        }

        public static void Important()
        {
            buttonsType = 3;
            pageNumber = 0;
        }
        public static void Room()
        {
            buttonsType = 4;
            pageNumber = 0;
        }
        public static void Safety()
        {
            buttonsType = 5;
            pageNumber = 0;
        }
        public static void Visual()
        {
            buttonsType = 6;
            pageNumber = 0;
        }
        public static void Fun()
        {
            buttonsType = 7;
            pageNumber = 0;
        }
        public static void Water()
        {
            buttonsType = 8;
            pageNumber = 0;
        }
        public static void Sound()
        {
            buttonsType = 9;
            pageNumber = 0;
        }
        public static void RightHand()
        {
            rightHanded = true;
        }

        public static void LeftHand()
        {
            rightHanded = false;
        }

        public static void EnableFPSCounter()
        {
            fpsCounter = true;
        }

        public static void DisableFPSCounter()
        {
            fpsCounter = false;
        }

        public static void EnableNotifications()
        {
            disableNotifications = false;
        }

        public static void DisableNotifications()
        {
            disableNotifications = true;
        }

        public static void EnableDisconnectButton()
        {
            disconnectButton = true;
        }

        public static void DisableDisconnectButton()
        {
            disconnectButton = false;
        }

        public static void ChangeButtonLayout()
        {
            buttonLayout++;
            if (buttonLayout > 3)
            {
                buttonLayout = 0;
            }
        }

        public static void ChangeMenutheme()
        {
            Theme++;
            if (Theme > 4)
            {
                Theme = 0;
            }
            if (Theme == 0)
            {
                backgroundColor = new ExtGradient { colors = GetSolidGradient(Color.grey) };
            }
            if (Theme == 1)
            {
                backgroundColor = new ExtGradient { colors = GetSolidGradient(Color.red) };
            }
            if (Theme == 2)
            {
                backgroundColor = new ExtGradient { colors = GetSolidGradient(Color.blue) };
            }
            if (Theme == 3)
            {
                backgroundColor = new ExtGradient { colors = GetSolidGradient(Color.cyan) };
            }
            if (Theme == 4)
            {
                backgroundColor = new ExtGradient { colors = GetSolidGradient(Color.yellow) };
            }
        }
        public static void FreezeInMenu()
        {
            if (menu != null)
            {
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().isKinematic = false;
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }
        public static void ChangeFlySpeed()
        {
            FlySpeed++;
            if (FlySpeed > 7)
            {
                FlySpeed = 0;
                speed = 0.8f;
            }
            if (FlySpeed == 0)
            {
                speed = 0.8f;
            }
            if (FlySpeed == 1)
            {
                speed = 1.8f;
            }
            if (FlySpeed == 2)
            {
                speed = 2.4f;
            }
            if (FlySpeed == 3)
            {
                speed = 3.3f;
            }
            if (FlySpeed == 4)
            {
                speed = 5f;
            }
            if (FlySpeed == 5)
            {
                speed = 8f;
            }
            if (FlySpeed == 6)
            {
                speed = 10f;
            }
            if (FlySpeed == 7)
            {
                speed = 12f;
            }

            Main.GetIndex("Change Fly Speed").overlapText = "Change Fly Speed : " + speed;
        }

        public static void CompPreset()
        {
            string[] compMod = {
                "No Finger Movement",
                "Tracers",
                "Chams",
                "Mosa Boost",
                "Long Arms",
            };
            foreach (string preset in compMod)
            {
                Main.Toggle(preset);
            }
            NotifiLib.ClearAllNotifications();
        }

        public static void GhostPreset()
        {
            string[] ghostMod = {
                "No Finger Movement",
                "Tracers",
                "Chams",
                "Platforms",
                "Long Arms",
                "Ghost Monke [<color=magenta>B</color>]",
                "Invis Monke [<color=magenta>A</color>]",
                "No Clip [<color=magenta>RT</color>]",
                "No Tag Freeze",
            };
            foreach (string preset in ghostMod)
            {
                Main.Toggle(preset);
            }
            NotifiLib.ClearAllNotifications();
        }
    }
}
