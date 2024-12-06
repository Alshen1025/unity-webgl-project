using UnityEditor;
using System.IO;
using System.Linq;
public class Builder
{ 
    public static void BuildWebGL()
    {
        // ºôµå °æ·Î ¼³Á¤
        string buildPath = "builds/WebGL"; // ºôµå ¿É¼Ç ¼³Á¤
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = EditorBuildSettings.scenes
            .Where(scene => scene.enabled) 
            .Select(scene => scene.path) .ToArray(); 
        buildPlayerOptions.locationPathName = buildPath;
        buildPlayerOptions.target = BuildTarget.WebGL;
        buildPlayerOptions.options = BuildOptions.None; // ºôµå ½ÇÇà
        BuildPipeline.BuildPlayer(buildPlayerOptions); 
    } 
}