using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 10f;
    
    
    //유니티 에디터에서 실행을 했을 떄, 1번 실행 되는 함수
    void Start() 
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position = this.transform.position + Vector3.forward * moveSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position = this.transform.position + Vector3.back * moveSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position = this.transform.position + Vector3.left * moveSpeed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position = this.transform.position + Vector3.right * moveSpeed;
        }
    }
}