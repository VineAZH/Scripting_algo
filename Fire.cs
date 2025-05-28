using UnityEngine;

public class Fire : MonoBehaviour
{
    public float lifeTime;
    public float increasingSpeed;
    public Temperature temp;
    public bool canDie = false;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            canDie = true;
        }
    }
    
    void Update()
    {
        lifeTime -= Time.deltaTime;

        if (canDie)
        {
            if (lifeTime <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (temp.currentTemp <= temp.maxTemp)
            {
                temp.currentTemp += increasingSpeed * Time.deltaTime;
            }
            else
            {
                temp.currentTemp = temp.maxTemp;
            }
        }
    }
}
