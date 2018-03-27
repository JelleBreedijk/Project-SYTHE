public interface IWeaponItem : IItem {
    int Durability { get; set; }
    int MaxDurability { get; }

    void SecondaryAction();
}
