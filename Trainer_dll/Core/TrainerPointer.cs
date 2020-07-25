using System;
using Trainer_dll.Interfaces;

namespace Trainer_dll.Core
{
    public abstract class TrainerPointer : ITrainerPointer
    {
        public string ProcessName { get; }
        public IntPtr BaseAddress { get; }
    }
}