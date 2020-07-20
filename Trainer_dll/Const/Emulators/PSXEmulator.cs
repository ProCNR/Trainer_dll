using Trainer_dll.Interfaces;

namespace Trainer_dll.Const.Emulators
{
    public class PSXEmulator : IEmulatorConst
    {
        
        public const byte BizHawk = 0;
        public const byte pSXfin = 1;
        public const byte ePSXe = 2;
        public const byte pcsxr = 3;
        public const byte mednafen = 4;
        public const byte RetroArch = 255; 
    }
}