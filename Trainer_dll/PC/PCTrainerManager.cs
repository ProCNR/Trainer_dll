using Trainer_dll.Core;
using Trainer_dll.Enums;
using Trainer_dll.Interfaces;

namespace Trainer_dll.PC
{
    /// <summary>
    /// PC Trainer Manager
    /// TODO
    /// </summary>
    public class PCTrainerManager : TrainerManager
    {
        public PCTrainerPointer TrainerPointer
        {
            get => (PCTrainerPointer) _trainerPointer;
            set => _trainerPointer = value;
        }
        
        public PCTrainerManager()
            : base(TrainerType.PC_GAME)
        {
            
        }
    }
}