using UnityEngine;

public class Temperature : MonoBehaviour
{
    public float currentTemp = 36.6f;
    public float maxTemp = 37.5f;
    public float minTemp = 34;
    public float decreasingSpeed = 0.01f;
    public int damage;
    public PlayerHealth player;
    public float damageTimer = 1;
    public float damageDelay = 2;

    void Update()
    {
        currentTemp -= decreasingSpeed * Time.deltaTime;

        if (currentTemp <= minTemp)
        {
            damageTimer -= Time.deltaTime;
            
            if (damageTimer <= 0)
            {
                player.TakeDamage(damage);
                damageTimer = damageDelay;
            }
        }
    }
}
