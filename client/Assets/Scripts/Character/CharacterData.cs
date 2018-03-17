using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CharacterData
{
    public string name;
    public int hp;
    public int max_hp;
    public string thumbnail;
    public List<Skill> skills = new List<Skill>();

    public CharacterData(string _name, int _hp, string _thumbnail)
    {
        name = _name;
        hp = _hp;
        max_hp = _hp;
        thumbnail = _thumbnail;
    }
}
