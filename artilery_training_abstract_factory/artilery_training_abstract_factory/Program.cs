using System;

namespace artilery_training_abstract_factory
{
    public interface IArtilleryTrainingProgram
    {
        IBasicTrainingCourse CreateBasicTrainingCourse();
        IAdvancedTrainingCourse CreateAdvancedTrainingCourse();
    }

    class NATOArtilleryTrainingProgram : IArtilleryTrainingProgram
    {
        public IBasicTrainingCourse CreateBasicTrainingCourse()

        {
            return new NATOBasicTrainingCourse();
        }

        public IAdvancedTrainingCourse CreateAdvancedTrainingCourse()
        {
            return new NATOAdvancedTrainingCourse();
        }
    }

    class UkrainianArtilleryTrainingProgram : IArtilleryTrainingProgram
    {
        public IBasicTrainingCourse CreateBasicTrainingCourse()
        {
            return new UkrainianBasicTrainingCourse();
        }

        public IAdvancedTrainingCourse CreateAdvancedTrainingCourse()
        {
            return new UkrainianAdvancedTrainingCourse();
        }
    }

    public abstract class IBasicTrainingCourse
    {
        public abstract void Study();
    }

    public abstract class IAdvancedTrainingCourse
    {
        public abstract void Study();
    }

    class NATOBasicTrainingCourse : IBasicTrainingCourse
    {
        public override void Study()
        {
            Console.WriteLine("Studying basic artillery techniques for NATO weapons.");
        }
    }

    class NATOAdvancedTrainingCourse : IAdvancedTrainingCourse
    {
        public override void Study()
        {
            Console.WriteLine("Studying advanced artillery tactics for NATO weapons.");
        }
    }

    class UkrainianBasicTrainingCourse : IBasicTrainingCourse
    {
        public override void Study()
        {
            Console.WriteLine("Studying basic artillery techniques for Ukrainian weapons.");
        }
    }

    class UkrainianAdvancedTrainingCourse : IAdvancedTrainingCourse
    {
        public override void Study()
        {
            Console.WriteLine("Studying advanced artillery tactics for Ukrainian weapons.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IArtilleryTrainingProgram program;

            program = new UkrainianArtilleryTrainingProgram();

            IBasicTrainingCourse basicCourse = program.CreateBasicTrainingCourse();
            IAdvancedTrainingCourse advancedCourse = program.CreateAdvancedTrainingCourse();

            basicCourse.Study();
            advancedCourse.Study();

            program = new NATOArtilleryTrainingProgram();

            basicCourse = program.CreateBasicTrainingCourse();
            advancedCourse = program.CreateAdvancedTrainingCourse();

            basicCourse.Study();
            advancedCourse.Study();
        }
    }
}
