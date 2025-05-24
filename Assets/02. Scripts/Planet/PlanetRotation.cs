using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public Transform targetPlanet; //공전 대상이 되는 천체
    public float rotSpeed = 30f; //자전 속도
    public float revolutionSpeed = 100f; //공전 속도
    public bool isRevolution = false; //공전 여부
    
    void Update()
    {
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime); //자전 코드   
        if (isRevolution == true) //If 문 유니티에서 체크 시 활성화 
        {
            //공전 코드
           transform.RotateAround(targetPlanet.position, Vector3.up, revolutionSpeed * Time.deltaTime);
        }
        
    }
}
