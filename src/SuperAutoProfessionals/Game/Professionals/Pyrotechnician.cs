namespace SuperAutoProfessionals;

// 1. Do 2 damage to everyone when it dies
public class Pyrotechnician : Professional
{
    public override string CodeName => "Py";

    internal override bool On(Event e)
    {
        base.On(e);
        if (e.Code == EventCode.Die)
        {
            EnemyTeam.ForEach(enemy =>
            {
                Log($"Dealing 2 damage to {enemy}");
                Game.Attack(enemy, 2);
            });
        }
        return true;
    }
}