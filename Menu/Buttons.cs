using Sharp.Menu;
using Sharp.Mods;
using StupidTemplate.Classes;
using StupidTemplate.Mods;
using static StupidTemplate.Settings;

namespace StupidTemplate.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods | 0
                new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Opens the main settings page for the menu."},
                new ButtonInfo { buttonText = "Movement", method =() => SettingsMods.Movement(), isTogglable = false, toolTip = "Opens the movement page for the menu."},
                new ButtonInfo { buttonText = "Important", method =() => SettingsMods.Important(), isTogglable = false, toolTip = "Opens the important page for the menu."},
                new ButtonInfo { buttonText = "Room", method =() => SettingsMods.Room(), isTogglable = false, toolTip = "Opens the room page for the menu."},
                new ButtonInfo { buttonText = "Safety", method =() => SettingsMods.Safety(), isTogglable = false, toolTip = "Opens the safety page for the menu."},
                new ButtonInfo { buttonText = "Visual", method =() => SettingsMods.Visual(), isTogglable = false, toolTip = "Opens the visual page for the menu."},
                new ButtonInfo { buttonText = "Fun", method =() => SettingsMods.Fun(), isTogglable = false, toolTip = "Opens the fun page for the menu."},
                new ButtonInfo { buttonText = "Water", method =() => SettingsMods.Water(), isTogglable = false, toolTip = "Opens the water page for the menu."},
                new ButtonInfo { buttonText = "Sound", method =() => SettingsMods.Sound(), isTogglable = false, toolTip = "Opens the sound page for the menu."},
            },

            new ButtonInfo[] { // Settings | 1
                new ButtonInfo { buttonText = "Return", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
                new ButtonInfo { buttonText = "Change Button Layout", method =() => SettingsMods.ChangeButtonLayout(), toolTip = "Changes Button Layout.", isTogglable = false},
                new ButtonInfo { buttonText = "Change Menu Theme", method =() => SettingsMods.ChangeMenutheme(), toolTip = "Changes Menu Theme.", isTogglable = false},
                new ButtonInfo { buttonText = "Freeze Player In Menu", method =() => SettingsMods.FreezeInMenu(), toolTip = "Freezes you when menu is open.", isTogglable = true},
                new ButtonInfo { buttonText = "Change Fly Speed", method =() => SettingsMods.ChangeFlySpeed(), toolTip = "Changes the fly Speed.", isTogglable = false},
                new ButtonInfo { buttonText = "Comp Preset", method =() => SettingsMods.CompPreset(), toolTip = "Gives you a comp preset.", isTogglable = false},
                new ButtonInfo { buttonText = "Ghost Preset", method =() => SettingsMods.GhostPreset(), toolTip = "Gives you a ghost preset.", isTogglable = false},
            },

            new ButtonInfo[] { // Movement | 2
                new ButtonInfo { buttonText = "Return", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Platforms", method =() => Movement.Platforms(false), toolTip = "Gives you platforms", isTogglable = true },
                new ButtonInfo { buttonText = "Invis Platforms", method =() => Movement.Platforms(true), toolTip = "Gives you platforms", isTogglable = true },
                new ButtonInfo { buttonText = "Sticky Platforms [<color=red>TEST</color>]", method =() => Movement.StickyPlatforms(), toolTip = "Test for sticky plats", isTogglable = true },
                new ButtonInfo { buttonText = "Fly [<color=magenta>A</color>]", method =() => Movement.Fly(true, false, false, false), toolTip = "Lets you fly", isTogglable = true },
                new ButtonInfo { buttonText = "Reverse Fly [<color=magenta>A</color>]", method =() => Movement.Fly(false, false, false, true), toolTip = "Lets you fly", isTogglable = true },
                new ButtonInfo { buttonText = "Fly [<color=magenta>B</color>]", method =() => Movement.Fly(false, true, false, false), toolTip = "Lets you fly", isTogglable = true },
                new ButtonInfo { buttonText = "Fly [<color=magenta>RT</color>]", method =() => Movement.Fly(false, false, true, false), toolTip = "Lets you fly", isTogglable = true },
                new ButtonInfo { buttonText = "Ghost Monke [<color=magenta>B</color>]", method =() => Movement.GhostMods(true, false), toolTip = "Ghost Monke", isTogglable = true },
                new ButtonInfo { buttonText = "Invis Monke [<color=magenta>A</color>]", method =() => Movement.GhostMods(false, true), toolTip = "Invis Monke", isTogglable = true },
                new ButtonInfo { buttonText = "Mosa Boost", method =() => Movement.SpeedMods(true, false, false), toolTip = "Speeeed", isTogglable = true },
                new ButtonInfo { buttonText = "Speed Boost", method =() => Movement.SpeedMods(false, true, false), toolTip = "Speeeed", isTogglable = true },
                new ButtonInfo { buttonText = "Insane Speed Boost", method =() => Movement.SpeedMods(false, false, true), toolTip = "Speeeed", isTogglable = true },
                new ButtonInfo { buttonText = "TP Gun", method =() => Movement.TPGun(), toolTip = "TP Gun", isTogglable = true },
                new ButtonInfo { buttonText = "Rig Gun", method =() => Movement.RigGun(), toolTip = "Rig Gun", isTogglable = true },
                new ButtonInfo { buttonText = "Grab Gun", method =() => Movement.GrabRig(), toolTip = "Grab Rig", isTogglable = true },
                new ButtonInfo { buttonText = "No Clip [<color=magenta>RT</color>]", method =() => Movement.NoClip(), toolTip = "No Clip", isTogglable = true },
                new ButtonInfo { buttonText = "Long Arms", method =() => Movement.LongArms(false, true, false, false), disableMethod =() => Movement.LongArms(true, false, false, false), toolTip = "Arms", isTogglable = true },
                new ButtonInfo { buttonText = "Extreme Long Arms", method =() => Movement.LongArms(false, false, true, false), disableMethod =() => Movement.LongArms(true, false, false, false), toolTip = "Arms", isTogglable = true },
                new ButtonInfo { buttonText = "Small Arms", method =() => Movement.LongArms(false, false, false, true), disableMethod =() => Movement.LongArms(true, false, false, false), toolTip = "Arms", isTogglable = true },
                new ButtonInfo { buttonText = "Slide Control", method =() => Movement.SlideControl(), toolTip = "Slide Control", isTogglable = true },
                new ButtonInfo { buttonText = "No Tag Freeze", method =() => Movement.TagFreeze(true, false), toolTip = "Tag Freeze", isTogglable = true },
                new ButtonInfo { buttonText = "Force Tag Freeze", method =() => Movement.TagFreeze(false, true), disableMethod =() => Movement.TagFreeze(true, false), toolTip = "Tag Freeze", isTogglable = true },
                new ButtonInfo { buttonText = "Iron Man [<color=magenta>A/X</color>]", method =() => Movement.IronMan(), toolTip = "Iron Man", isTogglable = true },
                new ButtonInfo { buttonText = "Big Monke", method =() => Movement.BigMonke(), disableMethod = Movement.ResetSize, toolTip = "Sizes", isTogglable = true },
                new ButtonInfo { buttonText = "Small Monke", method =() => Movement.SmallMonke(), disableMethod = Movement.ResetSize, toolTip = "Sizes", isTogglable = true },
                new ButtonInfo { buttonText = "No Gravity", method =() => Movement.GravMods(true, false),  disableMethod =() => Movement.GravMods(false, true),toolTip = "grav", isTogglable = true },
                new ButtonInfo { buttonText = "Up and Down", method =() => Movement.UpDown(), toolTip = "Up and Down", isTogglable = true },
                new ButtonInfo { buttonText = "Left and Right", method =() => Movement.LeftRight(), toolTip = "Left and right", isTogglable = true },
                new ButtonInfo { buttonText = "Hover [<color=magenta>A</color>]", method =() => Movement.Hover(), toolTip = "Hover", isTogglable = true },
            },

            new ButtonInfo[] { // Important | 3
                new ButtonInfo { buttonText = "Return", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Disconnect", method =() => Important.Mods(true, false, false, false), toolTip = "Leave", isTogglable = false },
                new ButtonInfo { buttonText = "Quit GTAG", method =() => Important.Mods(false, true, false, false), toolTip = "Leave", isTogglable = false },
                new ButtonInfo { buttonText = "Join Code SHARP", method =() => Important.Mods(false, false, true, false), toolTip = "JoinsCode", isTogglable = false },
                new ButtonInfo { buttonText = "Join Discord", method =() => Important.Mods(false, false, false, true), toolTip = "Server", isTogglable = false },
                new ButtonInfo { buttonText = "Save Room Data", method =() => Important.RoomData(), toolTip = "Room Data to file", isTogglable = false },
                new ButtonInfo { buttonText = "Custom Boards", method =() => Important.Boards(true, false), disableMethod =() => Important.Boards(false, true), toolTip = "Boards", isTogglable = true, enabled = true },
            },

            new ButtonInfo[] { // Room | 4
                new ButtonInfo { buttonText = "Return", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Rejoin Room", method =() => Room.Rejoin(), toolTip = "Rejoin", isTogglable = false },
                new ButtonInfo { buttonText = "Join Code Daisy09", method =() => Room.Daisy09(), toolTip = "Join Code", isTogglable = false },
                new ButtonInfo { buttonText = "Join Code Pbbv", method =() => Room.Daisy09(), toolTip = "Join Code", isTogglable = false },
                new ButtonInfo { buttonText = "Join Code Echo", method =() => Room.Echo(), toolTip = "Join Code", isTogglable = false },
                new ButtonInfo { buttonText = "Join Code Spider", method =() => Room.Spider(), toolTip = "Join Code", isTogglable = false },
                new ButtonInfo { buttonText = "Join Code Statue", method =() => Room.Statue(), toolTip = "Join Code", isTogglable = false },
                new ButtonInfo { buttonText = "Join Code J3vu", method =() => Room.J3vu(), toolTip = "Join Code", isTogglable = false },
                new ButtonInfo { buttonText = "Join Code Banshee", method =() => Room.BanShee(), toolTip = "Join Code", isTogglable = false },
                new ButtonInfo { buttonText = "Join Code Mod", method =() => Room.Mod(), toolTip = "Join Code", isTogglable = false },
                new ButtonInfo { buttonText = "Join Code Mods", method =() => Room.Mods(), toolTip = "Join Code", isTogglable = false },
            },

            new ButtonInfo[] { // Safety | 5
                new ButtonInfo { buttonText = "Return", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Anti Report [<color=magenta>DISCONNECT</color>]", method =() => Safety.AntiReport(true, false), isTogglable = true, toolTip = "Anti report."},
                new ButtonInfo { buttonText = "Anti Report [<color=magenta>JOIN RANDOM GHOST CODE</color>]", method =() => Safety.AntiReport(false, true), isTogglable = true, toolTip = "Anti report."},
                new ButtonInfo { buttonText = "No Finger Movement", method =() => Safety.NoFinger(), isTogglable = true, toolTip = "No finger movement."},
                new ButtonInfo { buttonText = "Flush RPCS", method =() => Safety.FlushRPCS(), isTogglable = false, toolTip = "flush."},
            },

            new ButtonInfo[] { // Visual | 6
                new ButtonInfo { buttonText = "Return", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Tracers", method =() => Visual.Tracers(), isTogglable = true, toolTip = "Tracers."},
                new ButtonInfo { buttonText = "Chams", method =() => Visual.Chams(false), disableMethod =() => Visual.Chams(true), isTogglable = true, toolTip = "Chams."},
                new ButtonInfo { buttonText = "BoxESP", method =() => Visual.BoxESP(), isTogglable = true, toolTip = "Boxes."},
                new ButtonInfo { buttonText = "SphereESP", method =() => Visual.SphereESP(), isTogglable = true, toolTip = "Sphere."},
                new ButtonInfo { buttonText = "Bug ESP", method =() => Visual.AnimalESP(true, false), isTogglable = true, toolTip = "Bug esp."},
                new ButtonInfo { buttonText = "Bat ESP", method =() => Visual.AnimalESP(false, true), isTogglable = true, toolTip = "Bat esp."},
                new ButtonInfo { buttonText = "Set Time Day", method =() => Visual.Day(), isTogglable = false, toolTip = "Time."},
                new ButtonInfo { buttonText = "Set Time Night", method =() => Visual.Night(), isTogglable = false, toolTip = "Time."},
                new ButtonInfo { buttonText = "Set Time Evening", method =() => Visual.Evening(), isTogglable = false, toolTip = "Time."},
                new ButtonInfo { buttonText = "Set Time Morning", method =() => Visual.Morning(), isTogglable = false, toolTip = "Time."},
            },

            new ButtonInfo[] { // Fun | 7
                new ButtonInfo { buttonText = "Return", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Grab Bug [<color=magenta>RG</color>]", method =() => Fun.GrabBug(), isTogglable = true, toolTip = "Grabs the bug."},
                new ButtonInfo { buttonText = "Grab Bat [<color=magenta>RG</color>]", method =() => Fun.GrabBat(), isTogglable = true, toolTip = "Grabs the bat."},
                new ButtonInfo { buttonText = "Bug Gun", method =() => Fun.BugGun(), isTogglable = true, toolTip = "Grabs the bug."},
                new ButtonInfo { buttonText = "Bat Gun", method =() => Fun.BatGun(), isTogglable = true, toolTip = "Grabs the bat."},
                new ButtonInfo { buttonText = "UpsideDown Head", method =() => Fun.Upsidedownhead(), disableMethod = Fun.FixHead, isTogglable = true, toolTip = "Head Stuff."},
                new ButtonInfo { buttonText = "Backwards Head", method =() => Fun.Backhead(), disableMethod = Fun.FixHead, isTogglable = true, toolTip = "Head Stuff."},
                new ButtonInfo { buttonText = "HeadSpin [<color=cyan>X</color>]", method =() => Fun.HeadX(), disableMethod = Fun.FixHead, isTogglable = true, toolTip = "Head Stuff."},
                new ButtonInfo { buttonText = "HeadSpin [<color=cyan>Y</color>]", method =() => Fun.HeadY(), disableMethod = Fun.FixHead, isTogglable = true, toolTip = "Head Stuff."},
                new ButtonInfo { buttonText = "HeadSpin [<color=cyan>Z</color>]", method =() => Fun.HeadZ(), disableMethod = Fun.FixHead, isTogglable = true, toolTip = "Head Stuff."},
                new ButtonInfo { buttonText = "Change Name To DAISY09", method =() => Fun.NameTo(true, false, false, false, false), isTogglable = true, toolTip = "Names."},
                new ButtonInfo { buttonText = "Change Name To PBBV", method =() => Fun.NameTo(false, true, false, false, false), isTogglable = true, toolTip = "Names."},
                new ButtonInfo { buttonText = "Change Name To STATUE", method =() => Fun.NameTo(false, false, true, false, false), isTogglable = true, toolTip = "Names."},
                new ButtonInfo { buttonText = "Change Name To ECHO", method =() => Fun.NameTo(false, false, false, true, false), isTogglable = true, toolTip = "Names."},
                new ButtonInfo { buttonText = "Change Name To J3VU", method =() => Fun.NameTo(false, false, false, false, true), isTogglable = true, toolTip = "Names."},
            },

            new ButtonInfo[] { // Water | 8
                new ButtonInfo { buttonText = "Return", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Right WaterBending [<color=magenta>RG</color>]", method =() => Water.WaterBend(true, false), isTogglable = true, toolTip = "Water."},
                new ButtonInfo { buttonText = "Left WaterBending [<color=magenta>LG</color>]", method =() => Water.WaterBend(false, true), isTogglable = true, toolTip = "Water."},
                new ButtonInfo { buttonText = "Water Gun", method =() => Water.WaterGun(), isTogglable = true, toolTip = "Water."},
                new ButtonInfo { buttonText = "Water Aura", method =() => Water.WaterAura(), isTogglable = true, toolTip = "Water."},
            },

            new ButtonInfo[] { // Sound | 9
                new ButtonInfo { buttonText = "Return", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Keyboard Spammer [<color=magenta>RT</color>]", method =() => Sound.KeyboardSpam(), isTogglable = true, toolTip = "Sound Spammer."},
                new ButtonInfo { buttonText = "Button Spammer [<color=magenta>RT</color>]", method =() => Sound.ButtonSpam(), isTogglable = true, toolTip = "Sound Spammer."},
                new ButtonInfo { buttonText = "Metal Spammer [<color=magenta>RT</color>]", method =() => Sound.MetalSpam(), isTogglable = true, toolTip = "Sound Spammer."},
                new ButtonInfo { buttonText = "Crystal Spammer [<color=magenta>RT</color>]", method =() => Sound.CrystalSpam(), isTogglable = true, toolTip = "Sound Spammer."},
                new ButtonInfo { buttonText = "Ice Spammer [<color=magenta>RT</color>]", method =() => Sound.IceSpam(), isTogglable = true, toolTip = "Sound Spammer."},
                new ButtonInfo { buttonText = "Cynbal Spammer [<color=magenta>RT</color>]", method =() => Sound.CymbolSpam(), isTogglable = true, toolTip = "Sound Spammer."},
                new ButtonInfo { buttonText = "FoodPop Spammer [<color=magenta>RT</color>]", method =() => Sound.PopSpam(), isTogglable = true, toolTip = "Sound Spammer."},
                new ButtonInfo { buttonText = "Turkey Spammer [<color=magenta>RT</color>]", method =() => Sound.TurkeySpam(), isTogglable = true, toolTip = "Sound Spammer."},
                new ButtonInfo { buttonText = "Bite Spammer [<color=magenta>RT</color>]", method =() => Sound.BiteSpam(), isTogglable = true, toolTip = "Sound Spammer."},
                new ButtonInfo { buttonText = "DrumGiant Spammer [<color=magenta>RT</color>]", method =() => Sound.DrumGiant(), isTogglable = true, toolTip = "Sound Spammer."},
                new ButtonInfo { buttonText = "WebTouch Spammer [<color=magenta>RT</color>]", method =() => Sound.WebTouch(), isTogglable = true, toolTip = "Sound Spammer."},
            },
        };
    }
}
