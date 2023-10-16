
namespace SuperAutoProfessionals;

// My own idea #1
// 2. Gains double attack points after each attack.
public class Coder : Professional
{
    public override string CodeName => "Co";

    internal override bool On(Event e)
    {
        base.On(e);

        if (e.Code != EventCode.AfterAttack) return false;

        var p = e.Professional!;
        if (p != this) return false;

        p.Attack *= 2;

        var enemy = EnemyTeam.First;
        if (enemy == null) return false;

        Log($"Dealing {p.Attack} damage to {enemy}");
        Game.Attack(enemy, p.Attack);

        return true;
    }
}

