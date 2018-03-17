using UnityEngine;
using System.Collections;

public class SkillView : MonoBehaviour
{
    public SkillData Data;

    void Start()
    {
    }

    void Update()
    {

    }

    public void onClickSkill()
    {
        var game_obj = transform.Find("selected/on");
        if (game_obj.GetActive())
        {
            transform.Find("selected/on").SetActive(false);
            transform.Find("selected/off").SetActive(true);

            transform.Find("Cursor").SetActive(false);
        }
        else
        {
            transform.Find("selected/on").SetActive(true);
            transform.Find("selected/off").SetActive(false);

            transform.Find("Cursor").SetActive(true);
            transform.Find("Cursor").GetComponent<SkillDragDrop>();
            transform.Find("Cursor").transform.position = transform.position;
        }
    }

    public void SetSkill(SkillData data)
    {
        Data = data;

        //if (Data.hp <= 0)
        //    transform.Find("hp").SetActive(false);
        //else
        //    transform.Find("hp").SetText(Data.hp.ToString());

        //transform.Find("attack").SetText(Data.name.ToString());

        transform.SetTrigger(() =>
        {
            onClickSkill();
        }, false);
    }
}
