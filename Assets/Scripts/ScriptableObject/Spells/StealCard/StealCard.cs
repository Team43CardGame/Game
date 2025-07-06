using UnityEngine;

[CreateAssetMenu(fileName = "StealCard", menuName = "Scriptable Objects/StealCard")]
public class StealCard : SpellEffect
{
    void Awake()
    {
        this.duration = 1;
        this.targetsNumber = 1;
    }
    public override void OnHit(SpellEffect spell) { }

    public override void OnTurn(SpellEffect spell) { }

    public override void OnCast(SpellEffect spell)
    { 
        if (!HasEnded())
        {
            this.Effect(spell, targets[0]);
            this.EndSpell();
        }
    }

    public override void Effect(SpellEffect spell, int index)
    {
        this.spellManager.StealCard(caster, index);
    }
}
