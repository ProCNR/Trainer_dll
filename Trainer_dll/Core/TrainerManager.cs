using Trainer_dll.Enums;
using Trainer_dll.Interfaces;

namespace Trainer_dll.Core
{
    public abstract class TrainerManager : ITrainerManager
    {
        protected ITrainerPointer _trainerPointer;
        public TrainerType TrainerType { get; }

        protected TrainerManager(TrainerType trainerType)
        {
            TrainerType = trainerType;
        }

        
        
        
    }
}