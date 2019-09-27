using System.Runtime.InteropServices;

namespace GameBoy.CPU {
    [StructLayout(LayoutKind.Sequential, Size = 1)]
    public struct FlagRegister {
        public BitField Data;

        public bool C {
            get => Data[4];
            set => Data[4] = value;
        }

        public bool H {
            get => Data[5];
            set => Data[5] = value;
        }

        public bool N {
            get => Data[6];
            set => Data[6] = value;
        }

        public bool Z {
            get => Data[7];
            set => Data[7] = value;
        }
    }
}
