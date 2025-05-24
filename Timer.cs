using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public int minutes = 1;
    public float seconds  = 30;

    void Update()
    {
        seconds -= Time.deltaTime;
        print($"Осталось времени: {minutes} минут, {seconds} секунд");
        
        if (seconds <= 0)
        {
            if (minutes > 0)
            {
                seconds += 59;
                minutes -= 1;
            }
            else
            {
                int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneIndex);
                print("Время вышло, начните с начала!");
            }
        }
    }
}
