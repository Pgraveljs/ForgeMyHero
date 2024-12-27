namespace ForgeMyHero.Domain.Dungeons_Dragons.ValuesObjects;
public record class DD5Class(int Id, string Name);

public class ClassRepository
{
    public List<DD5Class> GetDD5Classes()
    {
        return
        [
            new DD5Class(1, "Barbare"),
            new DD5Class(2, "Barde"),
            new DD5Class(3, "Clerc"),
            new DD5Class(4, "Druide"),
            new DD5Class(5, "Ensorceleur"),
            new DD5Class(6, "Guerrier"),
            new DD5Class(7, "Magicien"),
            new DD5Class(8, "Moine"),
            new DD5Class(9, "Paladin"),
            new DD5Class(10, "Rôdeur"),
            new DD5Class(11, "Roublard"),
            new DD5Class(12, "Sorcier")
        ];
    }
}