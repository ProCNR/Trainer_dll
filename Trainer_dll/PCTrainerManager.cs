using Trainer_dll.Interfaces;

namespace Trainer_dll
{
    public class PCTrainerManager : ITrainerManager
    {
        public TrainerPointer TrainerPointer { get; set; }
        
    }
}