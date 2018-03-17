using UnityEngine;
using System.Collections;

public class MonsterView : MonoBehaviour
{
    public MonsterData Data;

    void Start()
    {
    }

    void Update()
    {

    }

    public void SetMonster(MonsterData data)
    {
        Data = data;

        transform.Find("HP").SetText(string.Format("HP : {0}/{1}", Data.hp.ToString(), Data.hp.ToString()));

        //transform.Find("label").SetText(Data.name.ToString());
        Texture texture = Resources.Load<Texture2D>("monster/0" + data.image);
        transform.Find("image").SetTexture(texture);
    }

    public void Damage(int damage)
    {
        Data.hp -= damage;
        transform.Find("HP").SetText(string.Format("HP : {0}/{1}", Data.hp.ToString(), Data.hp.ToString()));
    }
}
