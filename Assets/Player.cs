using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayableCharacter;

public class Enemy : Character
{
    public Enemy(string name, int life, bool alive) : base(name)
    {

    }
    public override void TakeDamage()
    {
        this.HealthPoints -= 1;
    }

}

public class Player : Character
{
    public Player(string name, int life, bool alive) : base(name)
    {

    }
    public override void TakeDamage()
    {
        
    }
}
