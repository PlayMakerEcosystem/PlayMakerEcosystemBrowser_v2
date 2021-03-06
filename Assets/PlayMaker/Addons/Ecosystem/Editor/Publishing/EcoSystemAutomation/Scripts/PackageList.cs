//-----------------------------------------------------------------------
// <copyright file="PackageList.cs" company="Hutong Games LLC">
// Copyright (c) Hutong Games LLC. All rights reserved.
// </copyright>
// <author name="Jean Fabre"</author>
//-----------------------------------------------------------------------

using System.Collections.Generic;
using UnityEngine;

namespace HutongGames.PlayMakerEditor.Addons.Ecosystem.Publishing
{

    [CreateAssetMenu(fileName = "EcoAutoPacker", menuName = "NewEcoAutoPacker", order = 1)]
    [System.Serializable]
    // Package List
    public class PackageList : ScriptableObject
    {
        #region Lists
        [SerializeField]
        public List<string> includeFolders = new List<string>();
        [SerializeField]
        public List<string> excludeFolders = new List<string>();
        [SerializeField]
        public List<string> includeFiles = new List<string>();
        [SerializeField]
        public List<string> excludeFiles = new List<string>();
        [SerializeField]
        public List<string> youTubeLists = new List<string>();
        [SerializeField]
        public List<string> webLinkList = new List<string>();
        [SerializeField]
        public List<string> modulesList = new List<string>();
        [SerializeField]
        public List<string> ecoFilterList = new List<string>();
        [SerializeField]
        public List<string> foldersToInclude = new List<string>();
        [SerializeField]
        public List<string> filesToInclude = new List<string>();
        [SerializeField]
        public List<string> foldersToExclude = new List<string>();
        [SerializeField]
        public List<string> filesToExclude = new List<string>();
        #endregion

        #region Strings
        [SerializeField]
        public string author;
        [SerializeField]
        public string type;
        [SerializeField]
        public string version;
        [SerializeField]
        public string keyWords;
        [SerializeField]
        public string packageName;
        [SerializeField]
        public string targetDirectory;
		[SerializeField]
		public Authoring.Repositories targetRepository;
        [SerializeField]
        public string categoryString;
        [SerializeField]
        public string targetPackageTextFile;
        #endregion

        #region Selection lists

        [SerializeField]
        public string[] packagetypeselection = new[] { "ActionPackage", "SamplePackage", "TemplatePackage" };
        [SerializeField]
        public int packagetypeselected = 0;
        [SerializeField]
        public string[] UminVselection = new[] { "ActionPackage", "SamplePackage", "TemplatePackage" };
        [SerializeField]
        public int UminVselected = 0;
        [SerializeField]
        public string[] PMminVselection = new[] { "ActionPackage", "SamplePackage", "TemplatePackage" };
        [SerializeField]
        public int PMminVselected = 0;
        [SerializeField]
        public string[] Pingtype = new[] { "None", "Asset Path", "Menu" };
        [SerializeField]
        public int Pingtypeselected = 0;
 
		public static string[] uMinVersion = new[] { "4.7", "5.0", "5.1", "5.2", "5.3", "5.4", "5.5", "5.6", "2017.1","2017.2","2017.3","2017.4","2018","2018.1","2018.2","2018.3" };

        [SerializeField]
        public int uMinVersionSelected = 0;

		public static string[] pmMinVersion = new[] { "1.8.0", "1.8.1", "1.8.2", "1.8.3", "1.8.4", "1.8.5","1.8.6","1.9"};

        [SerializeField]
        public int pmMinVersionSelected = 0;
        #region categoryList
        [SerializeField]
        public string[] categoryList = new[] { "API", "Analytics", "AnimateVariables", "Animation", "Android", "Animator", "Application", "Array"
        , "AssetBundle", "Audio", "AudioMixer", "BlendShapes", "Camera", "Color", "Convert", "CrossPlatformInput", "Debug", "Device", "Editor"
            , "Effects", "Encryption", "Files", "FOV", "GarbageCollection", "GameObject", "GUI", "GuiElement", "GUILayout", "Input", "JSON", "Level"
            , "Lights", "Logic", "Material", "Math", "Mesh", "Microphone", "MobileGameController", "Movement", "NavMeshAgent", "NoiseModule"
            , "Particles", "Physics", "Physics2D", "PlayerPrefs", "QualitySettings", "Quaternion", "Rect", "RectTransform", "RenderSettings", "Renderer"
            , "Resources", "Screen", "ScriptControl", "ShapeModule", "Social", "Sprite", "StateMachine", "String", "Texture", "Time", "Transform"
            , "Trigonometry", "UnityAds", "UnityObject", "Vector2", "Vector3", "VideoClip", "VideoPlayer", "VR", "Web", "WebCam", "uGui"};
        [SerializeField]
        public int categorySelected = 0;
        #endregion

        #endregion

        #region Others
        [SerializeField]
        public Object assetPath;
        [SerializeField]
        public Object pingMenu;
        [SerializeField]
        public bool fileExistsCheck = true;
        [SerializeField]
        public bool expandedList = false;
        [SerializeField]
        public bool showList = true;
        [SerializeField]
        public bool showSetFoldersAndFiles = true;
        [SerializeField]
        public bool foldout = true;
        #endregion
    }
}