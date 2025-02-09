using BepInEx;
using Ionic.Zlib;
using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Sharp.Mods
{
    internal class Water
    {
        public static void WaterGun()
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
                        GorillaTagger.Instance.myVRRig.SendRPC("RPC_PlaySplashEffect", RpcTarget.All, new object[]
                        {
                            GorillaTagger.Instance.offlineVRRig.rightHandTransform.position,
                            GorillaLocomotion.Player.Instance.rightControllerTransform.rotation,
                            4f,
                            150f,
                            true,
                            false,
                        });
                        Safety.FlushRPCS();
                    }
                    else
                    {
                        GorillaTagger.Instance.offlineVRRig.enabled = true;
                    }
                }
            }
        }
        public static void WaterAura()
        {
            if (ControllerInputPoller.instance.rightGrab || UnityInput.Current.GetKey(UnityEngine.KeyCode.L))
            {
                GorillaTagger.Instance.myVRRig.SendRPC("RPC_PlaySplashEffect", RpcTarget.All, new object[]
                {
                        GorillaTagger.Instance.offlineVRRig.transform.position + new Vector3(UnityEngine.Random.Range(-0.2f, 0.8f),UnityEngine.Random.Range(-0.2f, 0.8f),UnityEngine.Random.Range(-0.2f, 0.8f)),
                        Quaternion.Euler(new Vector3(UnityEngine.Random.Range(0, 360), UnityEngine.Random.Range(0, 360), UnityEngine.Random.Range(0, 360))),
                        4f,
                        150f,
                        true,
                        false,
                });
                Safety.FlushRPCS();
            }
        }
        public static void WaterBend(bool r, bool l)
        {
            if (r)
            {
                if (ControllerInputPoller.instance.rightGrab || UnityInput.Current.GetKey(UnityEngine.KeyCode.L))
                {
                    GorillaTagger.Instance.myVRRig.SendRPC("RPC_PlaySplashEffect", RpcTarget.All, new object[] 
                    {  
                        GorillaLocomotion.Player.Instance.rightControllerTransform.position,
                        GorillaLocomotion.Player.Instance.rightControllerTransform.rotation,
                        4f,
                        150f,
                        true,
                        false,
                    });
                    Safety.FlushRPCS();
                }
            }
            if (l)
            {
                if (ControllerInputPoller.instance.leftGrab)
                {
                    GorillaTagger.Instance.myVRRig.SendRPC("RPC_PlaySplashEffect", RpcTarget.All, new object[]
                    {
                        GorillaLocomotion.Player.Instance.leftControllerTransform.position,
                        GorillaLocomotion.Player.Instance.leftControllerTransform.rotation,
                        4f,
                        150f,
                        true,
                        false,
                    });
                    Safety.FlushRPCS();
                }
            }
        }
    }
}
