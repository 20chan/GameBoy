using System.Runtime.InteropServices;

namespace GameBoy.Videos {
    [StructLayout(LayoutKind.Sequential, Size = 1)]
    public struct LCDControlRegister {
        public BitField Data;

        public bool WindowDisplay {
            get => Data[0];
            set => Data[0] = value;
        }

        // Data[1] = OBJDisplayEnable
        // Data[2] = OBJSize
        // Data[3] = BGTileMapDisplaySelect
        // Data[4] = BGTileDataSelect
        // Data[5] = WindowDisplayEnable
        // Data[6] = WindowTileMapDisplaySelect
        // Data[7] = LCDDisplayEnable
    }
}
