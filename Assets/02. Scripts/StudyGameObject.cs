using System;
using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    public GameObject prefab;
    public GameObject destroyObj;
    public Vector3 pos;
    public Quaternion rot;

    void Start()
    {
        Debug.Log("생성되었습니다.");
        CreateAmongUs();
        
        Destroy(destroyObj, 3f);
    }

    /// <summary>
    /// 어몽어스 캐릯터 생성 및 이름 변경 
    /// </summary>
    public void CreateAmongUs()
    {
        GameObject obj = Instantiate(prefab, pos, rot);
        obj.name = "어몽어스캐릭터";

        Transform objTf = obj.transform;
        int count = objTf.childCount;
        
        Debug.Log($"캐릭터의 자식 오브 젝트 수 : {objTf.childCount}");
        Debug.Log($"캐릭터의 첫 번째 자식 오브젝트 : {objTf.GetChild(0).name}");
        Debug.Log($"캐릭터의 마지막 자식 오브젝트: {objTf.GetChild(count - 1).name}");
    }
}