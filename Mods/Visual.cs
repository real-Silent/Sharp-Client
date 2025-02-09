using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Animations.Rigging;

namespace Sharp.Mods
{
    internal class Visual
    {
        public static void Tracers()
        {
            foreach (VRRig rig in GorillaParent.instance.vrrigs)
            {
                if (rig != null && rig != GorillaTagger.Instance.offlineVRRig)
                {
                    GameObject traceObj = new GameObject();
                    LineRenderer line = traceObj.AddComponent<LineRenderer>();
                    line.useWorldSpace = true;
                    line.startWidth = 0.02f;
                    line.endWidth = 0.02f;
                    line.material = new Material(Shader.Find("GUI/Text Shader")); 
                    line.positionCount = 2;
                    line.SetPosition(0, GorillaLocomotion.Player.Instance.rightControllerTransform.position);
                    line.SetPosition(1, rig.transform.position);
                    if (rig.mainSkin.material.name.Contains("fected"))
                    {
                        line.startColor = Color.red;
                        line.endColor = Color.gray;
                    }
                    else
                    {
                        line.startColor = rig.playerColor;
                        line.endColor = Color.gray;
                    }

                    GameObject.Destroy(traceObj, Time.deltaTime); 
                }
            }
        }

        public static void BoxESP()
        {
            foreach (VRRig rig in GorillaParent.instance.vrrigs)
            {
                if (rig != null && rig != GorillaTagger.Instance.offlineVRRig)
                {
                    GameObject box = new GameObject();
                    box = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    box.transform.position = rig.transform.position;
                    box.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
                    box.GetComponent<Renderer>().material = new Material(Shader.Find("GUI/Text Shader"));
                    box.GetComponent<BoxCollider>().enabled = false;
                    box.GetComponent<Collider>().enabled = false;
                    if (rig.mainSkin.material.name.Contains("fected"))
                    {
                        box.GetComponent<Renderer>().material.color = Color.red;
                    }
                    else
                    {
                        box.GetComponent<Renderer>().material.color = Color.gray;
                    }
                    GameObject.Destroy(box, Time.deltaTime);
                }
            }
        }
        // Floating Bug Holdable - bug
        // Cave Bat Holdable - bat
        public static void Night()
        {
            BetterDayNightManager.instance.SetTimeOfDay(0);
        }

        public static void Evening()
        {
            BetterDayNightManager.instance.SetTimeOfDay(7);
        }

        public static void Morning()
        {
            BetterDayNightManager.instance.SetTimeOfDay(1);
        }

        public static void Day()
        {
            BetterDayNightManager.instance.SetTimeOfDay(3);
        }

        static GameObject bugg = GameObject.Find("Floating Bug Holdable");
        static GameObject batt = GameObject.Find("Cave Bat Holdable");
        public static void AnimalESP(bool bug, bool bat)
        {
            if (bug)
            {
                GameObject box = new GameObject();
                box = GameObject.CreatePrimitive(PrimitiveType.Cube);
                box.transform.position = bugg.transform.position;
                box.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
                box.GetComponent<Renderer>().material = new Material(Shader.Find("GUI/Text Shader"));
                box.GetComponent<BoxCollider>().enabled = false;
                box.GetComponent<Collider>().enabled = false;
                box.GetComponent<Renderer>().material.color = Color.gray;
                GameObject.Destroy(box, Time.deltaTime);
            }
            if (bat)
            {
                GameObject box = new GameObject();
                box = GameObject.CreatePrimitive(PrimitiveType.Cube);
                box.transform.position = batt.transform.position;
                box.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
                box.GetComponent<Renderer>().material = new Material(Shader.Find("GUI/Text Shader"));
                box.GetComponent<BoxCollider>().enabled = false;
                box.GetComponent<Collider>().enabled = false;
                box.GetComponent<Renderer>().material.color = Color.gray;
                GameObject.Destroy(box, Time.deltaTime);
            }
        }
        public static void SphereESP()
        {
            foreach (VRRig rig in GorillaParent.instance.vrrigs)
            {
                if (rig != null && rig != GorillaTagger.Instance.offlineVRRig)
                {
                    GameObject box = new GameObject();
                    box = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    box.transform.position = rig.transform.position;
                    box.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
                    box.GetComponent<Renderer>().material = new Material(Shader.Find("GUI/Text Shader"));
                    box.GetComponent<SphereCollider>().enabled = false;
                    box.GetComponent<Collider>().enabled = false;
                    if (rig.mainSkin.material.name.Contains("fected"))
                    {
                        box.GetComponent<Renderer>().material.color = Color.red;
                    }
                    else
                    {
                        box.GetComponent<Renderer>().material.color = Color.gray;
                    }
                    GameObject.Destroy(box, Time.deltaTime);
                }
            }
        }

        public static void Chams(bool disable)
        {
            if (disable)
            {
                foreach (VRRig rig in GorillaParent.instance.vrrigs)
                {
                    if (rig != null && rig != GorillaTagger.Instance.offlineVRRig)
                    {
                        rig.mainSkin.material.shader = Shader.Find("GorillaTag/UberShader");
                    }
                }
            }
            else
            {
                foreach (VRRig rig in GorillaParent.instance.vrrigs)
                {
                    if (rig != null && rig != GorillaTagger.Instance.offlineVRRig)
                    {
                        rig.mainSkin.material.shader = Shader.Find("GUI/Text Shader");
                        if (rig.mainSkin.material.name.Contains("fected"))
                        {
                            rig.mainSkin.material.color = Color.red;
                        }
                        else
                        {
                            rig.mainSkin.material.color = Color.gray;
                        }
                    }
                }
            }
        }
    }
}
