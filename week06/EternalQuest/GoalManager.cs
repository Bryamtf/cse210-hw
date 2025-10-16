public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    private int _simpleGoalsCompleted;
    private int _eternalGoalsRecorded;
    private int _checklistGoalsMastered;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _simpleGoalsCompleted = 0;
        _eternalGoalsRecorded = 0;
        _checklistGoalsMastered = 0;
    }

    public void Start()
    {
        int choice = 0;
        while (choice != 6)
        {
            DisplayPlayerInfo();
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    ListGoalDetails();
                    break;
                case 3:
                    SaveGoals();
                    break;
                case 4:
                    LoadGoals();
                    break;
                case 5:
                    RecordEvent();
                    break;
                case 6:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        string level = GetCurrentLevel();

        Console.WriteLine($"You have {_score} points - {level}");
        Console.WriteLine();
        Console.WriteLine("📊 Statistics:");
        Console.WriteLine($"   ✓ Simple Goals completed: {_simpleGoalsCompleted}");
        Console.WriteLine($"   ⚡ Eternal Goals recorded: {_eternalGoalsRecorded} times");
        Console.WriteLine($"   🎯 Checklist Goals mastered: {_checklistGoalsMastered}");
    }
    private string GetCurrentLevel()
    {
        switch (_score)
        {
            case < 500:
                return "Level 1: Beginner";
            case < 1000:
                return "Level 2: Apprentice";
            case < 2000:
                return "Level 3: Practitioner";
            case < 4000:
                return "Level 4: Expert";
            default:
                return "Level 5: Master";
        }
    }
    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals
        .Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetName()}");

        }

    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        int type = int.Parse(Console.ReadLine());

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case 1:
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case 2:
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("What is the bonus for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }
    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals available to record.");
            return;
        }

        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < _goals.Count)
        {
            Goal selectedGoal = _goals[choice];
            if (selectedGoal is SimpleGoal && selectedGoal.IsComplete())
            {
                Console.WriteLine("This goal is already completed!");
                return;
            }

            int pointsEarned = selectedGoal.GetPoints();
            bool wasCompleteBeforeRecord = selectedGoal.IsComplete();
            selectedGoal.RecordEvent();
            if (selectedGoal is SimpleGoal)
            {
                _simpleGoalsCompleted++;
            }
            else if (selectedGoal is EternalGoal)
            {
                _eternalGoalsRecorded++;
            }


            if (selectedGoal is ChecklistGoal checklistGoal)
            {
                if (checklistGoal.IsComplete() && !wasCompleteBeforeRecord)
                {
                    pointsEarned += checklistGoal.GetBonus();
                    _checklistGoalsMastered++;
                    DisplayCompletionCelebration(checklistGoal.GetName(), checklistGoal.GetBonus());

                }
            }

            _score += pointsEarned;
            if (!(selectedGoal is ChecklistGoal checklistGoal2 && checklistGoal2.IsComplete() && !wasCompleteBeforeRecord))
            {
                Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
                Console.WriteLine($"You now have {_score} points.");
            }
        }
        else
        {
            Console.WriteLine("Invalid goal selection.");
        }
    }
    private void DisplayCompletionCelebration(string goalName, int bonus)
    {
        Console.WriteLine();
        Console.WriteLine("═══════════════════════════════════════");
        Console.WriteLine("        🎉 GOAL MASTERED! 🎉");
        Console.WriteLine("═══════════════════════════════════════");
        Console.WriteLine($"You completed '{goalName}'!");
        Console.WriteLine($"Bonus unlocked: +{bonus} points! 💰");
        Console.WriteLine($"You now have {_score} points!");
        Console.WriteLine("═══════════════════════════════════════");
        Console.WriteLine();
    }


    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file?");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            outputFile.WriteLine($"{_simpleGoalsCompleted},{_eternalGoalsRecorded},{_checklistGoalsMastered}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
            ;
        }
    }


    public void LoadGoals()
    {
        Console.Write("What is the filename  for the goal file? ");
        string filename = Console.ReadLine();
        if (!File.Exists(filename))
        {
            Console.WriteLine($"File: '{filename}' not fund. ");
            return;
        }
        string[] lines = File.ReadAllLines(filename);
        _goals.Clear();
        _score = int.Parse(lines[0]);
        string[] stats = lines[1].Split(",");
        _simpleGoalsCompleted = int.Parse(stats[0]);
        _eternalGoalsRecorded = int.Parse(stats[1]);
        _checklistGoalsMastered = int.Parse(stats[2]);

        for (int i = 2; i< lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(":");
            string goalType = parts[0];
            string[] data = parts[1].Split(",");
            switch (goalType)
            {
                case "SimpleGoal":
                    string name = data[0];
                    string description = data[1];
                    int points = int.Parse(data[2]);
                    bool isComplete = bool.Parse(data[3]);
                    _goals.Add(new SimpleGoal(name, description, points, isComplete));
                    break;

                case "EternalGoal":
                    name = data[0];
                    description = data[1];
                    points = int.Parse(data[2]);
                    _goals.Add(new EternalGoal(name, description, points));
                    break;

                case "ChecklistGoal":
                    name = data[0];
                    description = data[1];
                    points = int.Parse(data[2]);
                    int bonus = int.Parse(data[3]);
                    int target = int.Parse(data[4]);
                    int amountCompleted = int.Parse(data[5]);
                    _goals.Add(new ChecklistGoal(name, description, points, target, bonus, amountCompleted));
                    break;

                default:
                    Console.WriteLine($"Unknown goal type: {goalType}");
                    break;
            }
        }
        Console.WriteLine($"Goals loaded from {filename}");

    }


}