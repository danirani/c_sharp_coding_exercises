using System;
using TechReturnersExercises;

namespace TechReturners.Exercises
{
    public class Exercise002
    {
        public static bool IsFromManchester(Person _person)
        {
            return _person.city == "Manchester";
        }

        public static bool CanWatchFilm(Person _person, int _ageLimit)
        {
            return _person.age >= _ageLimit;
        }
    }
}
