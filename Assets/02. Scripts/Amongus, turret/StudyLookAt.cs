using UnityEngine;

public class StudyLookAt : MonoBehaviour
{
    public Transform targetTf;
    public Transform turretHead;
    
    public GameObject bulletPrefab; //총알 프리팹
    public Transform[] firePos; //발사 위치

    public float timer;
    public float colldownTime;
    
    
    
    void Start() // 1번 실행 -> 무엇인가를 셋팅하는 기능
    {
        targetTf = GameObject.FindGameObjectWithTag("Player").transform;
    }
    
    void Update() // 무엇인가를 바라보는 기능
    {
        turretHead.LookAt(targetTf);
        
        timer += Time.deltaTime;
        if (timer >= colldownTime)
        {
            timer = 0f;
            for (int i = 0; i < firePos.Length; i++)
            {
                Instantiate(bulletPrefab, firePos[i].position,firePos[i].rotation);
            }
            
        }
    }
    
}
