namespace SuperAutoProfessionals;

// 2. Gains 5 attack points after each attack.
public class Boxer : Professional
{
    public override string CodeName => "Bo";

    private int attackBonus = 0;

    internal override bool On(Event e)
    {
        base.On(e);

        if (e.Code != EventCode.AfterAttack) return false;

        var p = e.Professional!;
        if (p != this) return false;

        p.Attack += 5;

        var enemy = EnemyTeam.First;
        if (enemy == null) return false;

        Log($"Dealing {p.Attack} damage to {enemy}");
        Game.Attack(enemy, p.Attack);

        return true;
    }
}

