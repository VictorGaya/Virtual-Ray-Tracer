using System;
using _Project.Ray_Tracer.Scripts.RT_Scene.RT_Point_Light;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace Editor.RT_Light
{
    [CustomEditor(typeof(RTPointLight))]
    public class RTLightInspector : UnityEditor.Editor
    {

        private RTPointLight rtLight;
        private Light light;

        void OnEnable()
        {
            rtLight = (RTPointLight)target;
            light = rtLight.gameObject.GetComponent<Light>();
            light.hideFlags = HideFlags.None;
        }

        private void OnPreSceneGUI()
        {
            rtLight.Color = rtLight.Color;
            rtLight.Ambient = rtLight.Ambient;
            rtLight.Diffuse = rtLight.Diffuse;
            rtLight.Specular = rtLight.Specular;
        }
    }
}