using UnityEngine;

public class StudyGameObject : MonoBehaviour
{
    public GameObject prefab;
    
    void Awake()
    {
        CreateAmongus();
    }

    public void CreateAmongus()
    {
        GameObject obj = Instantiate(prefab); //Instantiate(생성대상,생성위치,회전상태)
        obj.name = "어몽어스 캐릭터";
        
        //LootAt코드 -> targetTF
        //targetTf = GameObject.FindGameObjectWithTag("Player").transform;
        //어몽어스는 플레이어 태그로 설정 되어있음.
    }
    
}