using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public Transform targetPlanet;
    public float rotSpeed = 30f;
    public float revolutionSpeed = 100f;
    public bool isRevolution = false; 
    
    void Update()
    {
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime);    
        if (isRevolution == true)
        {
           transform.RotateAround(targetPlanet.position, Vector3.up, revolutionSpeed * Time.deltaTime);
        }
        
    }
}
