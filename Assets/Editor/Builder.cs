using UnityEditor;
using System.IO;
using System.Linq;
public class Builder
{ 
    public static void BuildWebGL()
    {
        // ���� ��� ����
        string buildPath = "builds/WebGL"; // ���� �ɼ� ����
        BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
        buildPlayerOptions.scenes = EditorBuildSettings.scenes
            .Where(scene => scene.enabled) 
            .Select(scene => scene.path) .ToArray(); 
        buildPlayerOptions.locationPathName = buildPath;
        buildPlayerOptions.target = BuildTarget.WebGL;
        buildPlayerOptions.options = BuildOptions.None; // ���� ����
        BuildPipeline.BuildPlayer(buildPlayerOptions); 
    } 
}
//�׽�Ʈ�� �������
