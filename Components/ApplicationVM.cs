namespace BlazorWasm.Components;

public class ApplicationVM
{
    public int Id { get; set; }
    public Another Another { get; set; } = new();
}

public class Another
{
    public int Number { get; set; }
}