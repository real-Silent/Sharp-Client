using GorillaNetworking;
using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.Animations.Rigging;

namespace Sharp.Mods
{
    internal class Fun
    {
        static GameObject bugg = GameObject.Find("Floating Bug Holdable");
        static GameObject batt = GameObject.Find("Cave Bat Holdable");
        public static void GrabBug()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                bugg.transform.position = GorillaLocomotion.Player.Instance.rightControllerTransform.position;
                bugg.transform.rotation = GorillaLocomotion.Player.Instance.rightControllerTransform.rotation;
            }
        }
        public static void GrabBat()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                batt.transform.position = GorillaLocomotion.Player.Instance.rightControllerTransform.position;
                batt.transform.rotation = GorillaLocomotion.Player.Instance.rightControllerTransform.rotation;
            }
        }

        public static void HeadX()
        {
            GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.x += 10f;
        }
        public static void HeadZ()
        {
            GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.z += 10f;
        }
        public static void HeadY()
        {
            GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.y += 10f;
        }
        public static void BugGun()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                RaycastHit raycastHit; Physics.Raycast(GorillaLocomotion.Player.Instance.rightControllerTransform.position - GorillaLocomotion.Player.Instance.rightControllerTransform.up,
                    -GorillaLocomotion.Player.Instance.rightControllerTransform.up,
                    out raycastHit);
                {
                    GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    gameObject.transform.localScale = new Vector3(0.15f, 0.15f, 0.15f);
                    gameObject.GetComponent<Renderer>().material.color = Color.white;
                    gameObject.transform.position = raycastHit.point;
                    UnityEngine.Object.Destroy(gameObject.GetComponent<BoxCollider>());
                    UnityEngine.Object.Destroy(gameObject.GetComponent<Rigidbody>());
                    UnityEngine.Object.Destroy(gameObject.GetComponent<Collider>());
                    UnityEngine.Object.Destroy(gameObject, Time.deltaTime);
                    gameObject.GetComponent<Collider>().enabled = false;
                    LineRenderer line = gameObject.AddComponent<LineRenderer>();
                    line.positionCount = 2;
                    line.SetPosition(0, GorillaLocomotion.Player.Instance.rightControllerTransform.position);
                    line.SetPosition(1, gameObject.transform.position);
                    line.useWorldSpace = true;
                    line.startColor = Color.green;
                    line.endColor = Color.red;
                    line.startWidth = 0.01f;
                    line.endWidth = 0.01f;
                    line.material = new Material(Shader.Find("GUI/Text Shader"));
                    if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.6f)
                    {
                        gameObject.GetComponent<Renderer>().material.color = Color.red;
                        bugg.transform.position = gameObject.transform.position;
                    }
                }
            }
        }
        public static void Reset()
        {
            GorillaTagger.Instance.offlineVRRig.enabled = true;
        }
        public static void Upsidedownhead()
        {
            GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.z = 180f;
        }
        public static void FixHead()
        {
            GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.x = 0f;
            GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.z = 0f;
            GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.y = 0f;
        }
        public static void Backhead()
        {
            GorillaTagger.Instance.offlineVRRig.head.trackingRotationOffset.y = 180f;
        }
        public static void BatGun()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                RaycastHit raycastHit; Physics.Raycast(GorillaLocomotion.Player.Instance.rightControllerTransform.position - GorillaLocomotion.Player.Instance.rightControllerTransform.up,
                    -GorillaLocomotion.Player.Instance.rightControllerTransform.up,
                    out raycastHit);
                {
                    GameObject gameObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    gameObject.transform.localScale = new Vector3(0.15f, 0.15f, 0.15f);
                    gameObject.GetComponent<Renderer>().material.color = Color.white;
                    gameObject.transform.position = raycastHit.point;
                    UnityEngine.Object.Destroy(gameObject.GetComponent<BoxCollider>());
                    UnityEngine.Object.Destroy(gameObject.GetComponent<Rigidbody>());
                    UnityEngine.Object.Destroy(gameObject.GetComponent<Collider>());
                    UnityEngine.Object.Destroy(gameObject, Time.deltaTime);
                    gameObject.GetComponent<Collider>().enabled = false;
                    LineRenderer line = gameObject.AddComponent<LineRenderer>();
                    line.positionCount = 2;
                    line.SetPosition(0, GorillaLocomotion.Player.Instance.rightControllerTransform.position);
                    line.SetPosition(1, gameObject.transform.position);
                    line.useWorldSpace = true;
                    line.startColor = Color.green;
                    line.endColor = Color.red;
                    line.startWidth = 0.01f;
                    line.endWidth = 0.01f;
                    line.material = new Material(Shader.Find("GUI/Text Shader"));
                    if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.6f)
                    {
                        gameObject.GetComponent<Renderer>().material.color = Color.red;
                        batt.transform.position = gameObject.transform.position;
                    }
                }
            }
        }

        public static void NameTo(bool daisy, bool pbbv, bool statue, bool echo, bool j3vu)
        {
            if (daisy)
            {
                GorillaComputer.instance.currentName = "DAISY09";
                PhotonNetwork.LocalPlayer.NickName = "DAISY09";
                GorillaComputer.instance.offlineVRRigNametagText.text = "DAISY09";
                GorillaComputer.instance.savedName = "DAISY09";
                PlayerPrefs.SetString("playerName", "DAISY09");
                PlayerPrefs.Save();
            }
            if (pbbv)
            {
                GorillaComputer.instance.currentName = "PBBV";
                PhotonNetwork.LocalPlayer.NickName = "PBBV";
                GorillaComputer.instance.offlineVRRigNametagText.text = "DAISPBBVY09";
                GorillaComputer.instance.savedName = "PBBV";
                PlayerPrefs.SetString("playerName", "PBBV");
                PlayerPrefs.Save();
            }
            if (echo)
            {
                GorillaComputer.instance.currentName = "ECHO";
                PhotonNetwork.LocalPlayer.NickName = "ECHO";
                GorillaComputer.instance.offlineVRRigNametagText.text = "ECHO";
                GorillaComputer.instance.savedName = "ECHO";
                PlayerPrefs.SetString("playerName", "ECHO");
                PlayerPrefs.Save();
            }
            if (statue)
            {
                GorillaComputer.instance.currentName = "STATUE";
                PhotonNetwork.LocalPlayer.NickName = "STATUE";
                GorillaComputer.instance.offlineVRRigNametagText.text = "STATUE";
                GorillaComputer.instance.savedName = "STATUE";
                PlayerPrefs.SetString("playerName", "STATUE");
                PlayerPrefs.Save();
            }
            if (j3vu)
            {
                GorillaComputer.instance.currentName = "J3VU";
                PhotonNetwork.LocalPlayer.NickName = "J3VU";
                GorillaComputer.instance.offlineVRRigNametagText.text = "J3VU";
                GorillaComputer.instance.savedName = "J3VU";
                PlayerPrefs.SetString("playerName", "J3VU");
                PlayerPrefs.Save();
            }
        }
    }
}
