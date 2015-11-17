using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eSH.DAL.Entities;

namespace eSH.DAL.Seeding
{
    public class ESHInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ESHContext>
    {
        private Random _random;

        protected override void Seed(ESHContext context)
        {
            _random = new Random();
            SeedStats(context);
            SeedGames(context);
            SeedCharacters(context);
        }

        private static void SeedGames(ESHContext context)
        {
            var games = new List<Game>()
            {
                new Game() {Name = "SSBM"},
                new Game() {Name = "League Of Legends"},
                new Game() {Name = "DoTA 2"},
                new Game() {Name = "CS:GO"}
            };

            games.ForEach(g => context.Games.Add(g));
        }

        private void SeedCharacters(ESHContext context)
        {
            var characters = new List<Character>()
            {
                new Character() {GameId = _random.Next(1, 4), Name = "Skylz", StatsId = 1},
                new Character() {GameId = _random.Next(1, 4), Name = "MaSsiVe", StatsId = 2},
                new Character() {GameId = _random.Next(1, 4), Name = "Ve$pr", StatsId = 3},
                new Character() {GameId = _random.Next(1, 4), Name = "Mata", StatsId = 4},
                new Character() {GameId = _random.Next(1, 4), Name = "Faker", StatsId = 5},
                new Character() {GameId = _random.Next(1, 4), Name = "Trash", StatsId = 6},
                new Character() {GameId = _random.Next(1, 4), Name = "Czhk", StatsId = 7},
                new Character() {GameId = _random.Next(1, 4), Name = "Handii", StatsId = 8},
                new Character() {GameId = _random.Next(1, 4), Name = "TryHRD", StatsId = 9},
                new Character() {GameId = _random.Next(1, 4), Name = "Lyf", StatsId = 10}
            };

            characters.ForEach(g => context.Characters.Add(g));
        }

        private void SeedStats(ESHContext context)
        {
            var stats = GenerateRandomStats(10);
            stats.ForEach(s => context.Stats.Add(s));
        }

        private List<Stats> GenerateRandomStats(int numStats)
        {
            var stats = new List<Stats>();

            for (var i = 0; i < numStats; i++)
            {
                var stat = new Stats
                {
                    Dedication = _random.Next(8, 20),
                    DecisionMaking = _random.Next(8, 20),
                    Ego = _random.Next(8, 20),
                    Fame = _random.Next(8, 20),
                    Focus = _random.Next(8, 20),
                    Happieness = _random.Next(8, 20),
                    Mechanics = _random.Next(8, 20),
                    Salary = _random.Next(8, 20),
                    Teamwork = _random.Next(8, 20)
                };
                stats.Add(stat);
            }
            return stats;
        }
    }
}
