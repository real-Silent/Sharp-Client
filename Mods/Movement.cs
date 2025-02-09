using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using StupidTemplate.Mods;
using StupidTemplate.Menu;
using StupidTemplate;

namespace Sharp.Menu
{
    internal class Movement
    {
        static GameObject plat;
        static GameObject plat1;
        static GameObject stickyPlat;
        static GameObject stickyPlat1;
        public static void Platforms(bool invis)
        {
            if (plat == null)
            {
                if (ControllerInputPoller.instance.rightGrab)
                {
                    plat = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    plat.transform.localScale = new Vector3(0.02f, 0.3f, 0.4f);
                    plat.transform.position = GorillaLocomotion.Player.Instance.rightControllerTransform.position;
                    plat.transform.rotation = GorillaLocomotion.Player.Instance.rightControllerTransform.rotation;
                    if (invis)
                    {
                        plat.GetComponent<Renderer>().enabled = false;
                    }
                    else
                    {
                        plat.GetComponent<Renderer>().material.color = Settings.buttonColors[0].colors[0].color;
                    }
                }
            }
            if (plat1 == null)
            {
                if (ControllerInputPoller.instance.leftGrab)
                {
                    plat1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    plat1.transform.localScale = new Vector3(0.02f, 0.3f, 0.4f);
                    plat1.transform.position = GorillaLocomotion.Player.Instance.leftControllerTransform.position;
                    plat1.transform.rotation = GorillaLocomotion.Player.Instance.leftControllerTransform.rotation;
                    if (invis)
                    {
                        plat1.GetComponent<Renderer>().enabled = false;
                    }
                    else
                    {
                        plat1.GetComponent<Renderer>().material.color = Settings.buttonColors[0].colors[0].color;
                    }
                }
            }
            if (!ControllerInputPoller.instance.rightGrab && plat != null)
            {
                GameObject.Destroy(plat, Time.deltaTime);
            }
            if (!ControllerInputPoller.instance.leftGrab && plat1 != null)
            {
                GameObject.Destroy(plat1, Time.deltaTime);
            }
        }

        public static void StickyPlatforms()
        {
            if (plat == null && stickyPlat == null)
            {
                if (ControllerInputPoller.instance.rightGrab)
                {
                    plat = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    stickyPlat = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    plat.transform.localScale = new Vector3(0.02f, 0.3f, 0.4f);
                    stickyPlat.transform.localScale = new Vector3(0.02f, 0.3f, 0.4f);
                    plat.transform.position = GorillaLocomotion.Player.Instance.rightControllerTransform.position;
                    stickyPlat.transform.position = GorillaLocomotion.Player.Instance.rightControllerTransform.position + GorillaLocomotion.Player.Instance.rightControllerTransform.forward * 0.5f;
                    plat.transform.rotation = GorillaLocomotion.Player.Instance.rightControllerTransform.rotation;
                    stickyPlat.transform.rotation = GorillaLocomotion.Player.Instance.rightControllerTransform.rotation;
                    plat.GetComponent<Renderer>().material.color = Settings.buttonColors[0].colors[0].color;
                    stickyPlat.GetComponent<Renderer>().material.color = Settings.buttonColors[0].colors[0].color;
                }
            }
            if (plat1 == null && stickyPlat1 == null)
            {
                if (ControllerInputPoller.instance.leftGrab)
                {
                    plat1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    stickyPlat1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    plat1.transform.localScale = new Vector3(0.02f, 0.3f, 0.4f);
                    stickyPlat1.transform.localScale = new Vector3(0.02f, 0.3f, 0.4f);
                    plat1.transform.position = GorillaLocomotion.Player.Instance.leftControllerTransform.position;
                    stickyPlat1.transform.position = GorillaLocomotion.Player.Instance.leftControllerTransform.position + GorillaLocomotion.Player.Instance.leftControllerTransform.forward * 0.5f;
                    plat1.transform.rotation = GorillaLocomotion.Player.Instance.leftControllerTransform.rotation;
                    stickyPlat1.transform.rotation = GorillaLocomotion.Player.Instance.leftControllerTransform.rotation;
                    plat1.GetComponent<Renderer>().material.color = Settings.buttonColors[0].colors[0].color;
                    stickyPlat1.GetComponent<Renderer>().material.color = Settings.buttonColors[0].colors[0].color;
                }
            }
            if (!ControllerInputPoller.instance.rightGrab && plat != null && stickyPlat != null)
            {
                GameObject.Destroy(plat, Time.deltaTime);
                GameObject.Destroy(stickyPlat, Time.deltaTime);
            }
            if (!ControllerInputPoller.instance.leftGrab && plat1 != null && stickyPlat1 != null)
            {
                GameObject.Destroy(plat1, Time.deltaTime);
                GameObject.Destroy(stickyPlat1, Time.deltaTime);
            }
        }

        public static void Hover()
        {
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = false;
                GorillaTagger.Instance.offlineVRRig.transform.position = GorillaLocomotion.Player.Instance.bodyCollider.transform.position + Vector3.up;
            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;
            }
        }

        public static void Fly(bool A, bool B, bool Trigger, bool reverse)
        {
            if (A)
            {
                if (ControllerInputPoller.instance.rightControllerPrimaryButton)
                {
                    GorillaLocomotion.Player.Instance.transform.position += GorillaTagger.Instance.headCollider.transform.forward * Time.deltaTime * Main.speed;
                    GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
                }
            }
            if (reverse)
            {
                if (ControllerInputPoller.instance.rightControllerPrimaryButton)
                {
                    GorillaLocomotion.Player.Instance.transform.position += GorillaTagger.Instance.headCollider.transform.forward * Time.deltaTime * Main.speed * -1.4f;
                    GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
                }
            }
            if (B)
            {
                if (ControllerInputPoller.instance.rightControllerSecondaryButton)
                {
                    GorillaLocomotion.Player.Instance.transform.position += GorillaTagger.Instance.headCollider.transform.forward * Time.deltaTime * Main.speed;
                    GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
                }
            }
            if (Trigger)
            {
                if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.6f)
                {
                    GorillaLocomotion.Player.Instance.transform.position += GorillaTagger.Instance.headCollider.transform.forward * Time.deltaTime * Main.speed;
                    GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
                }
            }
        }

        public static void GhostMods(bool ghost, bool invis)
        {
            if (ghost)
            {
                if (ControllerInputPoller.instance.rightControllerSecondaryButton)
                {
                    GorillaTagger.Instance.offlineVRRig.enabled = false;
                }
                else
                {
                    GorillaTagger.Instance.offlineVRRig.enabled = true;
                }
            }
            if (invis)
            {
                if (ControllerInputPoller.instance.rightControllerPrimaryButton)
                {
                    GorillaTagger.Instance.offlineVRRig.enabled = false;
                    GorillaTagger.Instance.offlineVRRig.transform.position = new Vector3(2834239f, 2323f, 434f);
                }
                else
                {
                    GorillaTagger.Instance.offlineVRRig.enabled = true;
                }
            }
        }

        public static void SpeedMods(bool mosa, bool normal, bool insane)
        {
            if (mosa)
            {
                GorillaLocomotion.Player.Instance.maxJumpSpeed = 7.5f;
            }
            if (normal)
            {
                GorillaLocomotion.Player.Instance.maxJumpSpeed = 9.3f;
            }
            if (insane)
            {
                GorillaLocomotion.Player.Instance.maxJumpSpeed = 14.3f;
            }
        }

        static bool no = false;
        public static void TPGun()
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
                        if (!no)
                        {
                            GorillaLocomotion.Player.Instance.transform.position = gameObject.transform.position;
                            GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
                            no = true;
                        }
                    }
                    else
                    {
                        no = false;
                    }
                }
            }
        }

        public static void GrabRig()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = false;
                GorillaTagger.Instance.offlineVRRig.transform.position = GorillaLocomotion.Player.Instance.rightControllerTransform.position;
            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;
            }
        }
        public static void RigGun()
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
                        GorillaTagger.Instance.offlineVRRig.enabled = false;
                        GorillaTagger.Instance.offlineVRRig.transform.position = gameObject.transform.position;
                    }
                    else
                    {
                        GorillaTagger.Instance.offlineVRRig.enabled = true;
                    }
                }
            }
        }

        public static void NoClip()
        {
            foreach (MeshCollider mesh in GameObject.FindObjectsOfType<MeshCollider>())
            {
                if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.6f)
                {
                    mesh.enabled = false;
                }
                else
                {
                    mesh.enabled = true;
                }
            }
        }
        public static void BigMonke()
        {
            GorillaTagger.Instance.offlineVRRig.NativeScale = 4f;
            GorillaTagger.Instance.offlineVRRig.transform.localScale = Vector3.one * 4f;
        }
        public static void UpDown()
        {
            if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.5f)
            {
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity += Vector3.up * Time.deltaTime * 2f * 2.5f;
            }

            if (ControllerInputPoller.instance.leftControllerIndexFloat > 0.5f)
            {
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity += Vector3.up * Time.deltaTime * 2f * -2.5f;
            }
        }
        public static void LeftRight()
        {
            if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.5f)
            {
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity += Vector3.right * Time.deltaTime * 2f * 2.5f;
            }

            if (ControllerInputPoller.instance.leftControllerIndexFloat > 0.5f)
            {
                GorillaLocomotion.Player.Instance.GetComponent<Rigidbody>().velocity += Vector3.right * Time.deltaTime * 2f * -2.5f;
            }
        }
        public static void GravMods(bool noGrav, bool off)
        {
            if (off)
            {
                GorillaTagger.Instance.bodyCollider.attachedRigidbody.useGravity = true;
            }
            if (noGrav)
            {
                GorillaTagger.Instance.bodyCollider.attachedRigidbody.useGravity = false;
            }
        }
        public static void SmallMonke()
        {
            GorillaTagger.Instance.offlineVRRig.NativeScale = 0.5f;
            GorillaTagger.Instance.offlineVRRig.transform.localScale = Vector3.one * 0.5f;
        }
        public static void ResetSize()
        {
            GorillaTagger.Instance.offlineVRRig.NativeScale = 1f;
            GorillaTagger.Instance.offlineVRRig.transform.localScale = Vector3.one * 1f;
        }
        public static void IronMan()
        {
            if (ControllerInputPoller.instance.leftControllerPrimaryButton)
            {
                GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity += -GorillaLocomotion.Player.Instance.leftControllerTransform.right / 4;
            }
            if (ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GorillaLocomotion.Player.Instance.bodyCollider.attachedRigidbody.velocity += GorillaLocomotion.Player.Instance.rightControllerTransform.right / 4;
            }
        }
        public static void TagFreeze(bool no, bool yes)
        {
            if (no)
            {
                GorillaLocomotion.Player.Instance.disableMovement = false;
            }
            if (yes)
            {
                GorillaLocomotion.Player.Instance.disableMovement = true;
            }
        }
        public static void SlideControl()
        {
            GorillaLocomotion.Player.Instance.slideControl = 1.8f;
        }
        public static void LongArms(bool disable, bool steam, bool extreme, bool small)
        {
            if (disable)
            {
                GorillaLocomotion.Player.Instance.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            }
            if (steam)
            {
                GorillaLocomotion.Player.Instance.transform.localScale = new Vector3(1.13f, 1.13f, 1.13f);
            }
            if (extreme)
            {
                GorillaLocomotion.Player.Instance.transform.localScale = new Vector3(1.33f, 1.33f, 1.33f);
            }
            if (small)
            {
                GorillaLocomotion.Player.Instance.transform.localScale = new Vector3(0.93f, 0.93f, 0.93f);
            }
        }
    }
}
