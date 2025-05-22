using UnityEditor;
using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    public GameObject obj;
    public Mesh msh;
    public Material mat;
    void Start()
    {
        CreateCube();
    }

    public void CreateCube()
    {
        //obj = new GameObject();
        //obj.name ="Cube";
        obj = new GameObject("Cube");
        
        obj.AddComponent<MeshRenderer>();
        obj.GetComponent<MeshRenderer>().material = mat;
        
        
        obj.AddComponent<MeshFilter>();
        obj.GetComponent<MeshFilter>().mesh = msh;
        
        obj.AddComponent<BoxCollider>();
        obj.GetComponent<BoxCollider>();
    }
}

