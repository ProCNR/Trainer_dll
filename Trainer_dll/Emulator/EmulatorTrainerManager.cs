using System;
using Trainer_dll.Core;
using Trainer_dll.Enums;
using Trainer_dll.Interfaces;

namespace Trainer_dll.Emulator
{
    public class EmulatorTrainerManager : TrainerManager
    {
        private int _platform;
        private byte _emulator;
        private string _version;

        public EmulatorTrainerPointer TrainerPointer
        {
            get => (EmulatorTrainerPointer) _trainerPointer;
            set => _trainerPointer = value;
        }

        public int Platform => _platform;
        public byte Emulator => _emulator;
        public string Version => _version;

        public EmulatorTrainerManager()
        : base(TrainerType.EMULATOR)
        {
            // TODO: INIT Trainer
            
        }

        public EmulatorTrainerManager(int platform, byte emulator, string version)
        :this()
        {
            SetPlatform(platform)
                .SetEmulator(emulator)
                .SetVersion(version);
        }


        public EmulatorTrainerManager SetPlatform(int PLATFORM_CONST)
        {
            _platform = PLATFORM_CONST;
            // TODO Platform logic
            
            
            return this;
        }
        
        public EmulatorTrainerManager SetEmulator(byte EMULATOR_CONST)
        {
            if (_platform == 0)
                throw new InvalidOperationException("No Platfrom set. You must set the target platform");
            _emulator = EMULATOR_CONST;
            // TODO Emulator logic
                     
            
            return this;
        }
        
        public EmulatorTrainerManager SetVersion(string versionNumber)
        {
            if (_emulator == 0)
                throw new InvalidOperationException("No Emulator set. You must set the target emulator");
            _version = versionNumber;
            // TODO Version logic
            
            
            return this;
        }
        
    }
}