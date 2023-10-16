using System;

namespace SuperAutoProfessionals.ConsoleApp;

internal class Program
{

	static void Main()
	{
		Professional?[] left = new Professional?[5];

		for (int i = 0; i < 5; i++)
		{
			Console.Write($"Enter left team professional at {i + 1}: ");
			var leftName = Console.ReadLine();
			Console.Write("Attack: ");
			var leftAttack = Console.ReadLine();
			Console.Write("Health: ");
			var leftHealth = Console.ReadLine();

			var leftProfessional = CreateProfessionalByCodeName(leftName);
			if (leftProfessional != null)
			{
				leftProfessional.Attack = string.IsNullOrEmpty(leftAttack) ? 5 : int.Parse(leftAttack);
				leftProfessional.Health = string.IsNullOrEmpty(leftHealth) ? 10 : int.Parse(leftHealth);
				left[i] = leftProfessional;
			}
		}

		Professional?[] right = new Professional?[5];

		for (int i = 0; i < 5; i++)
		{
			Console.Write($"Enter right team professional at {i + 1}: ");
			var rightName = Console.ReadLine();
			Console.Write("Attack: ");
			var rightAttack = Console.ReadLine();
			Console.Write("Health: ");
			var rightHealth = Console.ReadLine();

			var rightProfessional = CreateProfessionalByCodeName(rightName);
			if (rightProfessional != null)
			{
				rightProfessional.Attack = string.IsNullOrEmpty(rightAttack) ? 5 : int.Parse(rightAttack);
				rightProfessional.Health = string.IsNullOrEmpty(rightHealth) ? 10 : int.Parse(rightHealth);
				right[i] = rightProfessional;
			}
		}


		var game = new Game(new Team(left, Side.Left), new Team(right, Side.Right));

		var winner = game.RunTurn().Result;

		Console.WriteLine();
		Console.WriteLine();
		Console.WriteLine(winner == null ? "Draw" : $"Winner: {winner.Side}");
	}
	static Professional? CreateProfessionalByCodeName(string codeName)
	{
		switch (codeName)
		{
			case "At": return new Athlete();
			case "Bo": return new Boxer();
			case "Bu": return new Buthcer();
			case "GD": return new GraveDigger();
			case "Nu": return new Nurse();
			case "Co": return new Coder();
			case "Py": return new Pyrotechnician();
			case "Su": return new Surgeon();
			case "Tr": return new Trainer();
			default:
				return null;

		};
	}
}
