using UnityEngine;
using Debug = UnityEngine.Debug;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 10f;
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        
        Vector3 dir = new Vector3(h, 0, v);
        Vector3 nomalDir = dir.normalized; // 정규화 진행
        
        transform.position += nomalDir * moveSpeed * Time.deltaTime;
        
        //LookA() 바라보는 함수
        transform.LookAt(transform.position + nomalDir);
    }
}