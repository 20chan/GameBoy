using System.Runtime.InteropServices;

namespace GameBoy {
    [StructLayout(LayoutKind.Explicit, Size = 0x10000)]
    public unsafe struct MemoryMap {
        [FieldOffset(0)]
        public fixed byte Raw[0x10000];

        [FieldOffset(0)]
        public fixed byte ROMBlank00[0x4000];
        [FieldOffset(0x4000)]
        public fixed byte ROMBlankNN[0x4000];
        [FieldOffset(0x8000)]
        public fixed byte VRam[0x2000];
        [FieldOffset(0xa000)]
        public fixed byte ExternalRam[0x2000];
        [FieldOffset(0xc000)]
        public fixed byte WRAMBlank0[0x1000];
        [FieldOffset(0xd000)]
        public fixed byte WRAMBlankN[0x1000];
        // should be 0xc000?
        [FieldOffset(0xe000)]
        public fixed byte MirrorRam[0x1e00];
        [FieldOffset(0xfe00)]
        public fixed byte OAM[0xa0];
        [FieldOffset(0xfea0)]
        public fixed byte NotUsable[0x60];
        [FieldOffset(0xff00)]
        public fixed byte IORegisters[0x80];
        [FieldOffset(0xff80)]
        public fixed byte HRam[0x7F];
        [FieldOffset(0xffff)]
        public byte IE;
    }
}
