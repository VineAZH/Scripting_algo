using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCScript : MonoBehaviour
{
    // NPC's health
    public int health = 4;
    // NPC's level
    public int level = 1;
    // NPC's speed
    public float speed = 1.2f;
    // Mover
    public Vector3 newPosition;
    
    // Start is called before the first frame update
    void Start()
    {
      // Transfom.position
      newPosition = transform.position;
      // health + level = ...
      health += level;
      print("Healh: " + health);
    }

    // Update is called once per frame
    void Update()
    {
      // Changes position and prints it (Once per frame)
      newPosition.x += speed * Time.deltaTime;
      transform.position = newPosition;
      print("Position: " + transform.position);
    }
}