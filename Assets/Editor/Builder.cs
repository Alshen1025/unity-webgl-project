using UnityEditor;
using System.IO;
using System.Linq;
public class Builder
{ 
    public static void BuildWebGL()
    {
        // 빌드 경로 설정
        string buildPath = "builds/WebGL"; // 빌드 옵션 설정
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = EditorBuildSettings.scenes
            .Where(scene => scene.enabled) 
            .Select(scene => scene.path) .ToArray(); 
        buildPlayerOptions.locationPathName = buildPath;
        buildPlayerOptions.target = BuildTarget.WebGL;
        buildPlayerOptions.options = BuildOptions.None; // 빌드 실행
        BuildPipeline.BuildPlayer(buildPlayerOptions); 
    } 
}
//테스트용 변경사항
