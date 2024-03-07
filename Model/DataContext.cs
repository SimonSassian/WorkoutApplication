using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WorkoutApplication.Model
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {            
        }
        public DbSet<Exercise>? ExerciseList {get ; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Exercise>().HasData(
                new Exercise
                {
                    Id = 1,
                    Title = "Kätekõverdused jala tõstega",
                     Description = "Tavalised kätekõverdused korda mööda jalga tõstes",
                     Intensity = Exercise.ExerciseIntesity.Normal,
                     RecommendedDurationInSeconds = 40,
                     RecommendedTimeInSecondsBeforeExercise = 10,
                     RecommendedTimeInSecondsAfterExercise = 10
                },
                new Exercise
                {
                    Id = 2,
                    Title = "Slaalomhypped",
                     Description = "kykist hypped kyljelt kyljele",
                     Intensity = Exercise.ExerciseIntesity.High,
                     RecommendedDurationInSeconds = 40,
                     RecommendedTimeInSecondsBeforeExercise = 10,
                     RecommendedTimeInSecondsAfterExercise = 10,
                     RestTimeInstructions = "Venita reie esikylge"
                },
                new Exercise
                {
                    Id = 3,
                    Title = "Alt labi jooks",
                     Description = "kToenglamangus jooksmine",
                     Intensity = Exercise.ExerciseIntesity.Normal,
                     RecommendedDurationInSeconds = 40,
                     RecommendedTimeInSecondsBeforeExercise = 10,
                     RecommendedTimeInSecondsAfterExercise = 10
                });
        }
    }
}