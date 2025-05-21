using UnityEngine;

public class StudyComponent : MonoBehaviour
{
    private GameObject obj;
    public string changeName;

    void Start()
    {
        obj = GameObject.Find("Main Camera");
        obj.name = changeName;
    }
}
