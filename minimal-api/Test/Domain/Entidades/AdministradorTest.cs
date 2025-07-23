using minimal_api.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]

public class UnitTest1
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        //arrange
        var adm = new Administrador();

        //act
        adm.Email = "teste@teste.com";
        adm.Senha = "123";
        adm.Perfil = "Adm";
        adm.Id = 1;

        //assert

        Assert.AreEqual(1, adm.Id);
        Assert.AreEqual("teste@teste.com", adm.Email);
        Assert.AreEqual("123", adm.Senha);
        Assert.AreEqual("Adm", adm.Perfil);
    }
}