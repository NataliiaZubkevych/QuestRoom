using QuestRoom.Models;
using System.Linq;

namespace QuestRoom.Data
{
    public static class DbInitializer
    {
        public static void Initialize(QuestRoomContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Rooms.Any())
            {
                return;   // DB has been seeded
            }

            var rooms = new Room[]
            {
                new Room()
                {
                    Description = "Lux quest with your friends",
                    LevelOfDifficulty = Difficulty.Hard,
                    LevelOfFear = 1,
                    MinAmountOfPlayers = 2,
                    MaxAmountOfPlayers = 8,
                    Name = "Expert",
                    PhoneNumber = "56 23 65 23",
                    Rating = 2f,
                    TimeOfPassing = 23
                },
                new Room()
                {
                    Description = "Great Idea for quest before wedding day",
                    LevelOfDifficulty = Difficulty.Normal,
                    LevelOfFear = 1,
                    MinAmountOfPlayers = 1,
                    MaxAmountOfPlayers = 5,
                    Name = "Relax",
                    PhoneNumber = "380 88 888 88 88",
                    Rating = 3f,
                    TimeOfPassing = 120
                }

            };

            foreach (var room in rooms)
            {
                context.Rooms.Add(room);
            }
            context.SaveChanges();
        }
    }
}