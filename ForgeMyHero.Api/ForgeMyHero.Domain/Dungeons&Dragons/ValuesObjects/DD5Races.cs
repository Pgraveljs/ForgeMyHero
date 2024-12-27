namespace ForgeMyHero.Domain.Dungeons_Dragons.ValuesObjects;
// Definition of the race record class
public record class DD5Race(int Id, string Name);

public class RaceRepository
{
    // Method to get the list of races
    public List<DD5Race> GetDD5Races()
    {
        return
        [
            new DD5Race(1, "Elfe"),
            new DD5Race(2, "Halfelin"),
            new DD5Race(3, "Humain"),
            new DD5Race(4, "Nain"),
            new DD5Race(5, "Demi-elfe"),
            new DD5Race(6, "Demi-orc"),
            new DD5Race(7, "Gnome"),
            new DD5Race(8, "Sangdragon"),
            new DD5Race(9, "Tieffelin")
        ];
    }
}
