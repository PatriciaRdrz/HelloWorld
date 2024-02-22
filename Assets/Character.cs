using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayableCharacter
{

    public class Character
    {
        private string name;
        private int life = 1;
        public int Life { get => life; set => life = value; }

        public Character(string nombre)
        {
            this.name = name;
            Debug.Log("Hola, soy " + name);
        }
        ~Character()
        {
            Debug.Log("Destroyed");
        }
    }

}
