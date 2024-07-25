using System.Linq;
using JetBrains.Annotations;
using UnitTestingAPIs.ControllerBased.Controllers;
using Xunit;

namespace UnitTestingAPIs.UnitTests;

[TestSubject(typeof(WeatherForecastController))]
public class WeatherForecastControllerTest
{

    [Fact]
    public void GetWeatherForecastTest()
    {
        // Arrange
        var controller = new WeatherForecastController();
        
        // Act
        var result = controller.Get();
        
        // Assert
        Assert.Equal(5, result.Count());
    }
}