namespace GameBoy.CPU {
    public class Z80 {
        public Register Register;

        public void Execute(Instructions instruction, params InstructionTargets[] targets) {
            if (instruction == Instructions.Add) {
                var value = targets[0].GetByteValue(this);
                Add(value);
            }
        }

        public void Add(byte value) {
            var newValue = AddOverflow(Register.A, value, out var overflow);
            Register.F.Z = newValue == 0;
            Register.F.N = false;
            Register.F.C = overflow;
            Register.F.H = (Register.A & 0xf) + (value & 0xf) > 0xf;
        }

        private static byte AddOverflow(byte a, byte b, out bool overflow) {
            var c = (byte)(a + b);
            overflow = ((a ^ b) >= 0) & ((a ^ c) < 0);
            return c;
        }
    }
}
