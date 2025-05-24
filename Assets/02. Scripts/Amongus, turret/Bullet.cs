using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 100f; // 속도
    
    void Update()
    {
        transform.position += transform.up * bulletSpeed * Time.deltaTime; 
        //프레임 차이의 평균적인 이동을 위해 Time.deltaTime을 곱해 일정한 속도로 오브젝트를 이동시킵니다.
        
    }
}