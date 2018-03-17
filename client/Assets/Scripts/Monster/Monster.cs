using UnityEngine;
using System.Collections;

public class Monster : MonoBehaviour
{
    public MonsterData Monster_data;

    public Monster(MonsterData data)
    {
        Monster_data = data;
    }
}
