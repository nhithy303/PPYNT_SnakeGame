using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPYNT_SnakeGame
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    };
    public class Settings
    {
        public static int Speed { get; set; }
        public static int Score { get; set; }
        public static int Points { get; set; }
        public static int Width { get; set; }
        public static int Height { get; set; }
        public static bool IsGameOver { get; set; }
        public static bool IsGamePaused { get; set; }
        public static Direction InGameDirection { get; set; }
        public static bool enemyEnabled { get; set; }
        public static bool powerupEnabled { get; set; }
        public static double enemySpawnRate { get; set; }
        public static double powerupSpawnRate { get; set; }
        public static Brush headColor { get; set; }
        public static Brush bodyColor { get; set; }
        public static Brush foodColor { get; set; }
        public static string snakeShape { get; set; }
        public static string foodShape { get; set; }
        public static string difficulty { get; set; }
        public Settings()
        {
            Speed = 15;
            Points = 1;
            enemySpawnRate = 0.4;
            powerupSpawnRate = 0.5;
            headColor = Brushes.Orange;
            bodyColor = Brushes.Yellow;
            foodColor = Brushes.Purple;
            snakeShape = "circle";
            foodShape = "circle";
            Score = 0;
            Width = 16;
            Height = 16;
            IsGameOver = false;
            InGameDirection = Direction.Right;
            enemyEnabled = false;
            powerupEnabled = false;
            IsGamePaused = false;
        }
        public void resetGame()
        {
            Score = 0;
            IsGameOver = false;
            InGameDirection = Direction.Right;
            IsGamePaused = false;
        }
    }
}
