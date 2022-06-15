using System;
using Calculator.Lib;
using Xunit;

namespace Calculator.Test;

public class CalcTest
{
    private const double x = 5;
    private const double y = 10;
    
    [Theory]
    [InlineData(5, 10, 15)]
    [InlineData(15, 10, 25)]
    [InlineData(5, 5, 10)]
    public void Add_Test(double x1, double y1, double res)
    {
        var actual = Calc.Add(x1, y1);
        
        Assert.Equal(res, actual);
    }
    
    [Fact]
    public void Sub_Test()
    {
        var expected = x - y;
        var actual = Calc.Sub(x, y);
        
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void Mul_Test()
    {
        var expected = x * y;
        var actual = Calc.Mul(x, y);
        
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void Div_Test()
    {
        var expected = x / y;
        var actual = Calc.Div(x, y);
        
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void Div_Test_Exception()
    {
        var exception = Assert.Throws<DivideByZeroException>(() => Calc.Div(x, 0));
        Assert.IsType<DivideByZeroException>(exception);
    }
}