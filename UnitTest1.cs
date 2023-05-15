namespace revision_poo1;

public class UnitTest1
{
    [Fact]
    public void AjouterLiquide_10mlCafe_Tasse()
    {
        Contenant tasse = new Tasse();
        Liquide cafe = new Cafe(10);
        tasse.AjouterLiquide(cafe);

        Assert.Equal(10m, tasse.QuantiteLiquide());
    }
}