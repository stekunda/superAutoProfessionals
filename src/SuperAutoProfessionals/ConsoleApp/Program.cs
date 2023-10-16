using System;

namespace SuperAutoProfessionals.ConsoleApp;

internal class Program
{

	static void Main()
	{

		Console.WriteLine("Enter left team professional at 1: ");
		var left1 = Console.ReadLine();
		Console.WriteLine("Attack: ");
		var left1Attack = Console.ReadLine();
		Console.WriteLine("Health: ");
		var left1Health = Console.ReadLine();

		var leftOne = CreateProfessionalByCodeName(left1);
		if (leftOne != null)
		{
			leftOne.Attack = string.IsNullOrEmpty(left1Attack) ? 2 : int.Parse(left1Attack);
			leftOne.Health = string.IsNullOrEmpty(left1Attack) ? 5 : int.Parse(left1Attack);
		}


		Console.WriteLine("Enter left team professional at 2: ");
		var left2 = Console.ReadLine();
		Console.WriteLine("Attack: ");
		var left2Attack = Console.ReadLine();
		Console.WriteLine("Health: ");
		var left2Health = Console.ReadLine();

		var leftTwo = CreateProfessionalByCodeName(left2);
		if (leftTwo != null)
		{
			leftTwo.Attack = string.IsNullOrEmpty(left2Attack) ? 2 : int.Parse(left2Attack);
			leftTwo.Health = string.IsNullOrEmpty(left2Attack) ? 5 : int.Parse(left2Attack);
		}

		Console.WriteLine("Enter left team professional at 3: ");
		var left3 = Console.ReadLine();
		Console.WriteLine("Attack: ");
		var left3Attack = Console.ReadLine();
		Console.WriteLine("Health: ");
		var left3Health = Console.ReadLine();

		var leftThree = CreateProfessionalByCodeName(left3);
		if (leftThree != null)
		{
			leftThree.Attack = string.IsNullOrEmpty(left3Attack) ? 2 : int.Parse(left3Attack);
			leftThree.Health = string.IsNullOrEmpty(left3Attack) ? 5 : int.Parse(left3Attack);
		}

		Console.WriteLine("Enter left team professional at 4: ");
		var left4 = Console.ReadLine();
		Console.WriteLine("Attack: ");
		var left4Attack = Console.ReadLine();
		Console.WriteLine("Health: ");
		var left4Health = Console.ReadLine();

		var leftFour = CreateProfessionalByCodeName(left4);
		if (leftFour != null)
		{
			leftFour.Attack = string.IsNullOrEmpty(left4Attack) ? 2 : int.Parse(left4Attack);
			leftFour.Health = string.IsNullOrEmpty(left4Attack) ? 5 : int.Parse(left4Attack);
		}

		Console.WriteLine("Enter left team professional at 5: ");
		var left5 = Console.ReadLine();
		Console.WriteLine("Attack: ");
		var left5Attack = Console.ReadLine();
		Console.WriteLine("Health: ");
		var left5Health = Console.ReadLine();

		var leftFive = CreateProfessionalByCodeName(left5);
		if (leftFive != null)
		{
			leftFive.Attack = string.IsNullOrEmpty(left5Attack) ? 2 : int.Parse(left5Attack);
			leftFive.Health = string.IsNullOrEmpty(left5Attack) ? 5 : int.Parse(left5Attack);
		}


		Console.WriteLine("Enter right team professional at 1: ");
		var right1 = Console.ReadLine();
		Console.WriteLine("Attack: ");
		var right1Attack = Console.ReadLine();
		Console.WriteLine("Health: ");
		var right1Health = Console.ReadLine();

		var rightOne = CreateProfessionalByCodeName(right1);
		if (rightOne != null)
		{
			rightOne.Attack = string.IsNullOrEmpty(right1Attack) ? 2 : int.Parse(right1Attack);
			rightOne.Health = string.IsNullOrEmpty(right1Attack) ? 5 : int.Parse(right1Attack);
		}


		Console.WriteLine("Enter right team professional at 2: ");
		var right2 = Console.ReadLine();
		Console.WriteLine("Attack: ");
		var right2Attack = Console.ReadLine();
		Console.WriteLine("Health: ");
		var right2Health = Console.ReadLine();

		var rightTwo = CreateProfessionalByCodeName(right2);
		if (rightTwo != null)
		{
			rightTwo.Attack = string.IsNullOrEmpty(right2Attack) ? 2 : int.Parse(right2Attack);
			rightTwo.Health = string.IsNullOrEmpty(right2Attack) ? 5 : int.Parse(right2Attack);
		}


		Console.WriteLine("Enter right team professional at 3: ");
		var right3 = Console.ReadLine();
		Console.WriteLine("Attack: ");
		var right3Attack = Console.ReadLine();
		Console.WriteLine("Health: ");
		var right3Health = Console.ReadLine();

		var rightThree = CreateProfessionalByCodeName(right3);
		if (rightThree != null)
		{
			rightThree.Attack = string.IsNullOrEmpty(right3Attack) ? 2 : int.Parse(right3Attack);
			rightThree.Health = string.IsNullOrEmpty(right3Attack) ? 5 : int.Parse(right3Attack);
		}


		Console.WriteLine("Enter right team professional at 4: ");
		var right4 = Console.ReadLine();
		Console.WriteLine("Attack: ");
		var right4Attack = Console.ReadLine();
		Console.WriteLine("Health: ");
		var right4Health = Console.ReadLine();

		var rightFour = CreateProfessionalByCodeName(right4);
		if (rightFour != null)
		{
			rightFour.Attack = string.IsNullOrEmpty(right4Attack) ? 2 : int.Parse(right4Attack);
			rightFour.Health = string.IsNullOrEmpty(right4Attack) ? 5 : int.Parse(right4Attack);
		}

		Console.WriteLine("Enter right team professional at 5: ");
		var right5 = Console.ReadLine();
		Console.WriteLine("Attack: ");
		var right5Attack = Console.ReadLine();
		Console.WriteLine("Health: ");
		var right5Health = Console.ReadLine();

		var rightFive = CreateProfessionalByCodeName(right5);
		if (rightFive != null)
		{
			rightFive.Attack = string.IsNullOrEmpty(right5Attack) ? 2 : int.Parse(right5Attack);
			rightFive.Health = string.IsNullOrEmpty(right5Attack) ? 5 : int.Parse(right5Attack);
		}


		var left = new Professional?[]
		{
			leftOne,
			leftTwo,
			leftThree,
			leftFour,
			leftFive

		};

		var right = new Professional?[]
		{
			rightOne,
			rightTwo,
			rightThree,
			rightFour,
			rightFive
		};

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
			case "-": return null;
			default:
				Console.WriteLine("Invalid code name");
				Console.WriteLine("Enter a valid code name: ");
				codeName = Console.ReadLine();
				return CreateProfessionalByCodeName(codeName);

		};
	}
}
