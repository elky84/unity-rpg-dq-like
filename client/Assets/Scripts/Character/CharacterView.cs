using UnityEngine;
using System.Collections;

public class CharacterView : MonoBehaviour
{
    public CharacterData Data;

    void Start()
    {
    }

    void Update()
    {

    }

    public void SetCharacter(CharacterData data)
    {
        Data = data;

        transform.Find("HP/label").SetText(string.Format("HP : {0}/{1}", Data.hp.ToString(), Data.hp.ToString()));

        transform.Find("name/label").SetText(Data.name.ToString());
        Texture texture = Resources.Load<Texture2D>("character/0" + data.thumbnail);
        transform.Find("info/thumbnail").SetTexture(texture);
    }

    public void Damage(int damage)
    {
        Data.hp -= damage;
        transform.Find("hp").SetText(Data.hp.ToString());
    }
}
