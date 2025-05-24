using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float speed = 2.5f;
    public Transform target;
    public int playerDamage = 2;

    // Does it every frame
    
    void Update()
    {
        // Changes NPC's position
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        // Faces to NPC
        transform.LookAt(target.position);
    }
    
    // Does it when contacts Player
    
    void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        player.TakeDamage(playerDamage);
        print("Враг атакует!");
    }
}
