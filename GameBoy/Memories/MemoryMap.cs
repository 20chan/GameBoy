using System.Runtime.InteropServices;

namespace GameBoy.Memories {
    [StructLayout(LayoutKind.Explicit, Size = 0x10000)]
    public struct MemoryMap {
        [FieldOffset(0), MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x10000)]
        public byte[] Raw;

        [FieldOffset(0), MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x4000)]
        public byte[] ROMBlank00;
        [FieldOffset(0x4000), MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x4000)]
        public byte[] ROMBlankNN;
        [FieldOffset(0x8000), MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x2000)]
        public byte[] VRam;
        [FieldOffset(0xa000), MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x2000)]
        public byte[] ExternalRam;
        [FieldOffset(0xc000), MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x1000)]
        public byte[] WRAMBlank0;
        [FieldOffset(0xd000), MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x1000)]
        public byte[] WRAMBlankN;
        // originally 0xe000 but useless
        [FieldOffset(0xc000), MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x1e00)]
        public byte[] MirrorRam;
        [FieldOffset(0xfe00), MarshalAs(UnmanagedType.ByValArray, SizeConst = 0xa0)]
        public byte[] OAM;
        [FieldOffset(0xfea0), MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x60)]
        public byte[] NotUsable;
        [FieldOffset(0xff00), MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x80)]
        public byte[] IORegisters;
        [FieldOffset(0xff80), MarshalAs(UnmanagedType.ByValArray, SizeConst = 0x7F)]
        public byte[] HRam;
        [FieldOffset(0xffff)]
        public byte IE;
    }
}
