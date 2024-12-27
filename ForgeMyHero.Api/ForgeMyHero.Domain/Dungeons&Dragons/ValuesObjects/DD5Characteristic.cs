namespace ForgeMyHero.Domain.Dungeons_Dragons.ValuesObjects;
public record class DD5Characteristic(int Id, string Name);

public class CharacteristicRepository
{
    public List<DD5Characteristic> GetDD5Characteristics()
    {
        return
        [
            new DD5Characteristic(1, "Force"),
            new DD5Characteristic(2, "Dextérité"),
            new DD5Characteristic(3, "Constitution"),
            new DD5Characteristic(4, "Intelligence"),
            new DD5Characteristic(5, "Sagesse"),
            new DD5Characteristic(6, "Charisme")
        ];
    }
}