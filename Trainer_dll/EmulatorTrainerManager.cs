using System.Runtime.CompilerServices;
using Trainer_dll.Interfaces;

namespace Trainer_dll
{
    public class EmulatorTrainerManager : ITrainerManager
    {
        private int _platform;
        private byte _emulator;
        private string _version;

        public TrainerPointer TrainerPointer { get; set; }
        
        public int Platform => _platform;
        public byte Emulator => _emulator;
        public string Version => _version;
        

        public EmulatorTrainerManager SetPlatform(int PLATFORM_CONST)
        {
            _platform = PLATFORM_CONST;
            
            // TODO Platform logic
            
            return this;
        }
        
        public EmulatorTrainerManager SetEmulator(byte EMULATOR_CONST)
        {
            _emulator = EMULATOR_CONST;
            
            // TODO Emulator logic
            
            return this;
        }
        
        public EmulatorTrainerManager SetVersion(string versionNumber)
        {
            _version = versionNumber;
            
            // TODO Version logic
            
            return this;
        }
        #region indexers

        public EmulatorTrainerManager this[int PLATFORM_CONST] => SetPlatform(PLATFORM_CONST);

        public EmulatorTrainerManager this[byte EMULATOR_CONST] => SetEmulator(EMULATOR_CONST);

        public EmulatorTrainerManager this[string emulatorVersion] => SetVersion(emulatorVersion);

        #endregion

        
    }
}