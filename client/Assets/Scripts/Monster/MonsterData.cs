using UnityEngine;
using System.Collections;

public class MonsterData
{
    public int attack;
    public int hp;
    public int max_hp;
    public string name;
    public string image;

    public MonsterData(string _name, int _attack, int _hp, string _image)
    {
        name = _name;
        attack = _attack;
        hp = _hp;
        max_hp = _hp;
        image = _image;
    }
}
