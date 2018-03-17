using System;
using System.Collections;
using UnityEngine;
using System.Collections.Generic;
using System.ComponentModel;

public class UIIngame : MonoBehaviour
{
    int turn = 0;
    Dictionary<int, CharacterData> dic_character = new Dictionary<int, CharacterData>();
    Dictionary<int, MonsterData> dic_monster = new Dictionary<int, MonsterData>();


    void Start()
    {
        CreateCharacter("메타트론", 1);
        CreateCharacter("울드", 2);
        CreateCharacter("스쿨드", 3);
        CreateCharacter("판도라", 4);

        transform.Find("battle/characters").GetComponent<UIGrid>().Reposition();

        CreateMonster("골렘", 1);
        CreateMonster("매지션", 2);

        transform.Find("battle/monsters").GetComponent<UIGrid>().Reposition();
    }

    void CreateCharacter(string name, int index)
    {
        var data = new CharacterData(name, UnityEngine.Random.Range(50, 100), index.ToString());

        dic_character.Add(index, data);

        var obj = Instantiate(Resources.Load("Prefabs/character")) as GameObject;
        obj.transform.parent = transform.Find("battle/characters");
        obj.transform.localPosition = Vector3.zero;
        obj.transform.localScale = Vector3.one;

        obj.GetComponent<CharacterView>().SetCharacter(data);

        string[] skill_names = { "파이어볼", "아이스볼", "라이트닝볼", "슬레이브" };
        for (int n = 0; n < 4; ++n)
        {
            var skill_data = new SkillData(skill_names[n], UnityEngine.Random.Range(50, 100));

            var skill_obj = Instantiate(Resources.Load("Prefabs/skill")) as GameObject;
            skill_obj.transform.parent = obj.transform.Find("SKILL");
            skill_obj.transform.localPosition = Vector3.zero;
            skill_obj.transform.localScale = Vector3.one;
            skill_obj.name = skill_names[n];
            skill_obj.transform.Find("label").SetText(skill_names[n]);

            skill_obj.GetComponent<SkillView>().SetSkill(skill_data);
        }
    }

    void CreateMonster(string name, int index)
    {
        var data = new MonsterData(name, UnityEngine.Random.Range(50, 100), UnityEngine.Random.Range(50, 100), index.ToString());

        dic_monster.Add(index, data);

        var obj = Instantiate(Resources.Load("Prefabs/monster")) as GameObject;
        obj.transform.parent = transform.Find("battle/monsters");
        obj.transform.localPosition = Vector3.zero;
        obj.transform.localScale = Vector3.one;

        obj.GetComponent<MonsterView>().SetMonster(data);
    }


    void Update()
    {

    }
}
