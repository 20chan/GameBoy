namespace GameBoy.CPU {
    public delegate ref byte GetByte(Z80 cpu);
    public class InstructionTargets {
        public Type type;

        public InstructionTargets(Type type) {
            this.type = type;
        }

        public GetByte GetByteValue;

        private static InstructionTargets Register(GetByte getByte) {
            return new InstructionTargets(Type.Register) {
                GetByteValue = getByte,
            };
        }

        public static InstructionTargets A = Register(cpu => ref cpu.Register.A);
        public static InstructionTargets B = Register(cpu => ref cpu.Register.B);
        public static InstructionTargets C = Register(cpu => ref cpu.Register.C);
        public static InstructionTargets D = Register(cpu => ref cpu.Register.D);
        public static InstructionTargets E = Register(cpu => ref cpu.Register.E);
        public static InstructionTargets H = Register(cpu => ref cpu.Register.H);
        public static InstructionTargets L = Register(cpu => ref cpu.Register.L);


        public enum Type {
            Register,
        }
    }
}
