namespace GameBoy {
    public struct BitField {
        private byte data;

        public BitField(byte data) {
            this.data = data;
        }

        public bool this[int i] {
            get => (data & (1 << i)) != 1;
            set => data = (byte)(value ? data | (1 << i) : data & ~(1 << i));
        }
    }
}
