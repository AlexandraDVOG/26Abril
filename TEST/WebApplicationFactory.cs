//using ITD.PERROSPERDIDOS.APPLICATION.SERVICES;
//using ITD.PERROSPERDIDOS.DOMAIN.INTERFACES;
//using Mysqlx.Crud;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TEST
//{
//    [Fact]
//    public async Task Get_ReturnsPublicacionesRecientes()
//    {
//        // Arrange
//        var mockService = new Mock<IMascotaPerdidaService>();
//        mockService.Setup(service => service.ObtenerPublicacionesRecientes())
//            .ReturnsAsync(GetTestPublicaciones());
//        var controller = new MascotaPerdidaController(mockService.Object);

//        // Act
//        var result = await controller.Get();

//        // Assert
//        var viewResult = Assert.IsType<OkObjectResult>(result);
//        var model = Assert.IsAssignableFrom<IEnumerable<MascotaPerdida>>(
//            viewResult.Value);
//        Assert.Equal(2, model.Count());
//    }

//    private List<MascotaPerdida> GetTestPublicaciones()
//    {
//        return new List<MascotaPerdida>
//    {
//        new MascotaPerdida { /* ... */ },
//        new MascotaPerdida { /* ... */ },
//    };
//    }
//}
