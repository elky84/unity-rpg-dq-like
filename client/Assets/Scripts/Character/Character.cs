using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour
{
    public CharacterData Character_data;

    public Character(CharacterData data)
    {
        Character_data = data;
    }
}
