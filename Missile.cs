using UnityEngine;

public class Missile : MonoBehaviour
{
    public int speed = 2;
    
    void Start()
    {
        Destroy(gameObject, 3);
    }
    
    void Update()
    {
       transform.position += transform.forward * speed * Time.deltaTime;
    }
    
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
