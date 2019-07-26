using UnityEditor;
using System;
using System.Linq;
class BuildMyGame
{
    public static void MyBuild()
    {
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = new[] { "Assets/Scenes/SampleScene.unity" };
        buildPlayerOptions.locationPathName = "SwitchBuild.nsp";
        buildPlayerOptions.target = BuildTarget.Switch;
        buildPlayerOptions.options = BuildOptions.None;
        EditorUserBuildSettings.switchCreateRomFile = true;
        EditorUserBuildSettings.switchNVNGraphicsDebugger = false;
        EditorUserBuildSettings.installInBuildFolder=true;
        PlayerSettings.SplashScreen.show = false;
        BuildPipeline.BuildPlayer(buildPlayerOptions);
    }
}