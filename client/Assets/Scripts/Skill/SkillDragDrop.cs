using UnityEngine;
using System.Collections;

public class SkillDragDrop : UIDragDropItem
{
    public static SkillDragDrop dragging = null;

    public bool forceMove = false;

    protected override void OnDragStart()
    {
        base.OnDragStart();
        dragging = this;
    }

    protected override void OnDragEnd()
    {
        base.OnDragEnd();
        dragging = null;
    }

    protected override void OnClone(GameObject ori)
    {
        var Skillview = ori.GetComponent<SkillView>();
        var oriData = Skillview.Data;
        GetComponent<SkillView>().SetSkill(oriData);
        base.OnClone(ori);
    }

    protected override void OnDragDropRelease(GameObject surface)
    {
        if (forceMove)
            return;

        var SkillView = gameObject.transform.parent.GetComponent<SkillView>();
        var SkillData = SkillView.Data;

        if (surface.transform.parent == null || surface.transform.parent.name != "monsters" || !surface.name.Contains("monster"))
        {
            base.OnDragDropRelease(surface);
            return;
        }

        var monsterView = surface.GetComponent<MonsterView>();
        monsterView.Damage(SkillData.attack);
        transform.SetActive(false);
        SkillView.onClickSkill();
        base.OnDragDropRelease(surface);

    }
}
