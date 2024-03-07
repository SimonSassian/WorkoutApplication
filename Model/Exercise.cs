using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WorkoutApplication.Model
{
    public record Exercise
    {
        public int Id {get; init;}
        public string? Title {get; init;}
        public string? Description {get; init;}
        public ExerciseIntesity Intensity {get; init;}
        public int RecommendedDurationInSeconds {get; init;}
        public int RecommendedTimeInSecondsBeforeExercise {get; init;}
        public int RecommendedTimeInSecondsAfterExercise {get; init;}
        public string? RestTimeInstructions {get; init;}

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum ExerciseIntesity {
            Low = 1,
            Normal = 2,
            High = 3

        }
    }   
}