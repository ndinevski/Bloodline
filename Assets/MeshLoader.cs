using UnityEngine;

public class MeshLoader : MonoBehaviour
{
    public string fbxPath = "/Users/atanasovskipetar/Documents/Projects/Bloodline/Assets/Models"; // Set the FBX file path in the Inspector

    void Start()
    {
        MeshFilter meshFilter = GetComponent<MeshFilter>();
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();

        // Load the FBX file and assign it to the Mesh Filter component
        Mesh fbxMesh = Resources.Load<Mesh>(fbxPath);
        meshFilter.mesh = fbxMesh;

        // Optional: Assign a material to the Mesh Renderer component
        // meshRenderer.material = yourMaterial;
    }
}
