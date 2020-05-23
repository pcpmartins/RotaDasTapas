using Microsoft.VisualStudio.TestTools.UnitTesting;
using RotaDasTapas.Repository;

namespace RotaDasTapas.Unit.Tests.Repository
{
    [TestClass]
    public class TapasRepositoryTests
    {
        private readonly ITapasRepository _tapasRepository;
        public TapasRepositoryTests()
        {
            _tapasRepository = new TapasRepository();
        }

        [TestMethod]
        public void GetAllTapas_NotArgument_ReturnValidModel()
        {
            //Arrange
            
            //Act
            var result = _tapasRepository.GetAllTapas();

            //Assert
            Assert.IsNotNull(result);
        }
        
        [TestMethod]
        public void GetTapaByname_ValidName_ReturnValidModel()
        {
            //Arrange
            var name = "Esquina";
            
            //Act
            var result = _tapasRepository.GetTapaByName(name);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(name,result.Name);
        }
        
        [TestMethod]
        public void GetTapaByname_InvalidName_ReturnValidModel()
        {
            //Arrange
            var name = "fake";
            
            //Act
            var result = _tapasRepository.GetTapaByName(name);

            //Assert
            Assert.IsNull(result);
        }
    }
}