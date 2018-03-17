using UnityEngine;
using System.Collections;

public class Skill : MonoBehaviour
{
    public SkillData skill_data;

    public Skill(SkillData data)
    {
        skill_data = data;
    }
}
