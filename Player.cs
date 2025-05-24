using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // Player health
    private int health = 10;
    public GameObject fireballPrefab;
    public Transform attackPoint;
    public int coins;
    public AudioSource audioSource;
    public AudioClip damageSound;
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab,attackPoint.position, attackPoint.rotation);
        }
    }
    
    // Hit Method
    public void TakeDamage(int damage)
    {
        health -= damage;
        
        if (health > 0)
        {
            audioSource.PlayOneShot(damageSound);
            print("Здоровье Игрока: " + health);
        }
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
            print("Вы погибли!");
        }
    }

    public void CollectCoins()
    {
        coins += 1;
        print("Взята монета! Количество монет: " + coins);
    }
}
