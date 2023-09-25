namespace SuperAutoProfessionals;

// 8. Friend spawned gets +2/+3
public class Surgeon : Professional
{
    public override string CodeName => "Su";

    internal override bool On(Event e)
    {
        base.On(e);
        if (e.Code == EventCode.Spawn)
        {
            var friend = e.Professional!;
            if (IsFriend(friend))
            {
                Log($"Buffing {friend} attack by 2 and health by 3");
                friend.Attack += 2;
                friend.Health += 3;
                return true;
            }
        }

        return false;
    }
}