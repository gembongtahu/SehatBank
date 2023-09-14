using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SehatBank
{
    internal class Workout
    {
        public int WorkoutID { get; }
        public string WorkoutName { get; }
        public int WorkoutCount { get; }
        public Workout(int workoutID, string workoutName, int workoutCount)
        {
            WorkoutID = workoutID;
            WorkoutName = workoutName;
            WorkoutCount = workoutCount;
        }
    }
}
