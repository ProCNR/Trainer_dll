namespace Trainer_dll.Const
{
    public static class  Platform
    {
        /// <summary>
        /// Conventions :
        /// - 0 is for PC Games
        /// - x000 : Constructor (e.g: 1000 Sony, 2000 Nintendo, 3000 SEGA...)
        /// - 0x00 : Type (home or handheld) 0 = Home consoles, 1 = Handhelds consoles
        /// - 00xx : Console
        /// </summary>
        
        // PC
        public const int PC_GAME = 0;
        
        // SONY
        public const int SONY_PLAYSTATION = 1001;
        public const int SONY_PLAYSTATION_2 = 1002;
        public const int SONY_PLAYSTATION_3 = 1003;
        public const int SONY_PLAYSTATION_PORTABLE = 1101;
        
        // Nintendo
        public const int NINTENDO_FAMICOM = 2001;
        public const int NINTENDO_NES = NINTENDO_FAMICOM; // Alias
        public const int NINTENDO_SUPER_FAMICOM = 2002;
        public const int NINTENDO_SNES = NINTENDO_SUPER_FAMICOM; // Alias
        public const int NINTENDO_N64 = 2003;
        public const int NINTENDO_GAMECUBE = 2004;
        public const int NINTENDO_WII = 2005;
        public const int NINTENDO_WIIU = 2006;
        public const int NINTENDO_SWITCH = 2007; // Count as Home Console
        public const int NINTENDO_GB = 2101;
        public const int NINTENDO_GBC = 2102;
        public const int NINTENDO_GBA = 2103;
        public const int NINTENDO_NDS = 2104;
        public const int NINTENDO_3DS = 2105;
        
        // SEGA
        public const int SEGA_MASTER_SYSTEM = 3001;
        public const int SEGA_MEGADRIVE = 3002;
        public const int SEGA_GENESIS = SEGA_MEGADRIVE; // Alias
        public const int SEGA_MEGACD = 3003;
        public const int SEGA_32X =  3004;
        public const int SEGA_SATURN =  3005;
        public const int SEGA_DREAMCAST =  3006;
        public const int SEGA_GAME_GEAR = 3101;
    }
}