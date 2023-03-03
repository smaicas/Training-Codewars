namespace MakeASpiral.Test;

public class ResolverTest
{
    private readonly int[,] _expectedTest05 = {
        {1, 1, 1, 1, 1},
        {0, 0, 0, 0, 1},
        {1, 1, 1, 0, 1},
        {1, 0, 0, 0, 1},
        {1, 1, 1, 1, 1}
    };

    private readonly int[,] _expectedTest8 = {
        {1, 1, 1, 1, 1, 1, 1, 1},
        {0, 0, 0, 0, 0, 0, 0, 1},
        {1, 1, 1, 1, 1, 1, 0, 1},
        {1, 0, 0, 0, 0, 1, 0, 1},
        {1, 0, 1, 0, 0, 1, 0, 1},
        {1, 0, 1, 1, 1, 1, 0, 1},
        {1, 0, 0, 0, 0, 0, 0, 1},
        {1, 1, 1, 1, 1, 1, 1, 1},
    };
    
    [Fact]
    public void Spiralize_Test05()
    {
        const int input = 5;

        int[,] actual = new int[input, input];
        new Resolver().PaintIteration(actual, 0, input);
        Assert.Equal(_expectedTest05, actual);
    }
    
    [Fact]
    public void Spiralize_Test08()
    {
        const int input = 8;
        
        int[,] actual = new int[input, input];
        new Resolver().PaintIteration(actual, 0, input);
        Assert.Equal(_expectedTest8, actual);
    }

    [Fact]
    public void SpiralizeJelitter_Test05()
    {
        const int input = 5;

        int[,] actual = new int[input, input];
        new Resolver().SpiralizeJelitter(actual, 0);
        Assert.Equal(_expectedTest05, actual);
    }
    
    [Fact]
    public void SpiralizeJelitter_Test08()
    {
        const int input = 8;
        
        int[,] actual = new int[input, input];
        new Resolver().SpiralizeJelitter(actual, 0);
        Assert.Equal(_expectedTest8, actual);
    }

    [Fact]
    public void SpiralizeKableado_Test05()
    {
        const int input = 5;

        int[,] actual = new Resolver().SpiralizeKableado(input);
        Assert.Equal(_expectedTest05, actual);
    }
    
    [Fact]
    public void SpiralizeKableado_Test08()
    {
        const int input = 8;
        
        int[,] actual = new Resolver().SpiralizeKableado(input);
        Assert.Equal(_expectedTest8, actual);
    }
    
    [Fact]
    public void SpiralizeKableado2_Test05()
    {
        const int input = 5;

        int[,] actual = new Resolver().SpiralizeKableado2(input);
        Assert.Equal(_expectedTest05, actual);
    }
    
    [Fact]
    public void SpiralizeKableado2_Test08()
    {
        const int input = 8;
        
        int[,] actual = new Resolver().SpiralizeKableado2(input);
        Assert.Equal(_expectedTest8, actual);
    }
    
    
    [Fact]
    public void SpiralizeCDeCompilador_Test05()
    {
        const int input = 5;

        int[,] actual = new Resolver().SpiralizeCDeCompilador(input);
        Assert.Equal(_expectedTest05, actual);
    }
    
    [Fact]
    public void SpiralizeCDeCompilador_Test08()
    {
        const int input = 8;
        
        int[,] actual = new Resolver().SpiralizeCDeCompilador(input);
        Assert.Equal(_expectedTest8, actual);
    }

}