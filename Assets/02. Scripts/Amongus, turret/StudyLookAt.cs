using UnityEngine;

public class StudyLookAt : MonoBehaviour
{
    public Transform targetTf;
    public Transform turretHead;
    
    public GameObject bulletPrefab; //총알 프리팹
    public Transform[] firePos; //발사 위치

    public float timer;
    public float cooldownTime; // 총알의 쿨타임
    
    
    
    void Start() // 1번 실행 -> 무엇인가를 셋팅하는 기능
    {
        targetTf = GameObject.FindGameObjectWithTag("Player").transform;
    }
    
    void Update() // 무엇인가를 바라보는 기능
    {
        turretHead.LookAt(targetTf);
        
        timer += Time.deltaTime;
        if (timer >= cooldownTime)
        {
            timer = 0f;
            for (int i = 0; i < firePos.Length; i++) // 총열을 4개 사용 했기 때문에 반복문 사용
            {
                Instantiate(bulletPrefab, firePos[i].position,firePos[i].rotation);
            }
            
        }
    }
    
}
