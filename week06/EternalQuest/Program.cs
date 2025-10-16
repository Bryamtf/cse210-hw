using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
//
// 1. LEVEL SYSTEM:
//    - The player has levels based on total points
//    - Levels: Beginner (0-499), Apprentice (500-999),
//      Practitioner (1000-1999), Expert (2000-3999), Master (4000+)
//    - The current level is displayed in DisplayPlayerInfo()
//
// 2. GOAL STATISTICS:
//    - Counter for completed Simple Goals
//    - Counter for registered Eternal Goals (total times recorded)
//    - Counter for mastered Checklist Goals (100% completed)
//    - Statistics are displayed on every menu screen
//    - They are saved and loaded with the goals file
//
// 3. SPECIAL CELEBRATION:
//    - When a ChecklistGoal is completed (reaches its target)
//    - A special message with decorative borders is displayed
//    - Clearly indicates the bonus earned
//    - Only appears the FIRST TIME it is completed
//
// 4. ADDITIONAL VALIDATIONS:
//    - Checks if the file exists before loading
//    - Prevents logging events for already completed SimpleGoals
//    - Handles errors for unknown goal types
//
// These features improve the user experience
// and add gamification elements that motivate users
// to keep working on their goals.
// ========================================

