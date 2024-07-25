using JetBrains.Annotations;
using UnitTestingAPIs.Minimal;
using Xunit;

namespace UnitTestingAPIs.UnitTests;

[TestSubject(typeof(WeatherForecastsMinimal))]
public class WeatherForecastsMinimalTest
{

    [Fact]
    public void GetWeatherForecastsTest()
    {
        // Arrange
        
        // Act
        var result = WeatherForecastsMinimal.GetWeatherForecasts();
        
        // Assert
        Assert.Equal(5, result.Length);
    }
}