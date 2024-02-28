using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game123
{
    public class HelloWorld : MonoBehaviour
    {
        Enemy enemy;
        Player player;
        // Start is called before the first frame update
        void Start()
        {
            enemy = new Enemy(" Voldemort", 2, true);
            player = new Player(" HP", 4, true);
        }

        // Update is called once per frame
        void Update()
        {
            player.TakeDamage();
            enemy.TakeDamage();
            Debug.Log("Vida player: " + enemy.HealthPoints + " Vida enemy: " + enemy.HealthPoints);
        }
    }
}
