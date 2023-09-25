// My own idea #2
// Before each attack, gain attack points equal to half of the enemy's health.
namespace SuperAutoProfessionals;
public class Athlete : Professional
{
    public override string CodeName => "At";

    private int attackBonus = 0;

    internal override bool On(Event e)
    {
        base.On(e);
        if (e.Code != EventCode.BeforeAttack) return false;

        var p = e.Professional!;
        if (p != this) return false;

        var enemy = EnemyTeam.First;
        if (enemy == null) return false;

        attackBonus += enemy.Health / 2;
        p.Attack += attackBonus;


        Log($"Dealing {p.Attack} damage to {enemy}");
        Game.Attack(enemy, p.Attack);

        return true;


    }
}