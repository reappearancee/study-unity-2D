using UnityEngine;
using Debug = UnityEngine.Debug;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 10f;
    void Update()
    {
        //Input Manager : 편의성을 위해 입력키를 미리 저장해 둠
        // Horizontal : A-D, Vertical : W-S
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        
        Vector3 dir = new Vector3(h, 0, v); //(h 좌우 ,0 높이(점프 안할 시 0), z 앞 뒤)
        Vector3 nomalDir = dir.normalized; // 정규화 진행 -> 대각선 키 입력시 이동속도가 높아지는 것 방지
                                           // 같이 눌렀을 때 길이가 1을 넘지 않게
        
        transform.position += nomalDir * moveSpeed * Time.deltaTime;
        
        //LookAt() 바라보는 함수
        transform.LookAt(transform.position + nomalDir);
    }
}