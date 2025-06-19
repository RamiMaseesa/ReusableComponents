namespace MyGame.Interfaces {
    public interface IHealth {
        int Health { get; }

        public void RemoveHealthPoints(int healthToRemove);

        public void GenerateHearts();

        public void AddHealthPoint();
    }
}