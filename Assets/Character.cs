using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayableCharacter
{

    public abstract class Character
    {
        private string name;
        private int healthPoints = 10;
        public int HealthPoints { get => healthPoints; set => healthPoints = value; }

        public Character(string name)
        {
            this.name = name;
            Debug.Log(name + "ha muerto");
        }
        ~Character()
        {
            Debug.Log("Destroyed");
        }
        public abstract void TakeDamage();
    }

}
