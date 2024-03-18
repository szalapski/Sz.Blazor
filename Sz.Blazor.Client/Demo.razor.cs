namespace Sz.Blazor.Client;

public partial class Demo
{
    public bool ShowExample1 { get; set; } = false;

    private void ToggleAll() => ShowExample1 = !ShowExample1;

    public string blockExampleString = """
        <div class="unaffected">Previous block.</div>
            <Reveal When = "ShowExample1" >
                <div> Example </ div >
            <div> Example second element</div>
            </Reveal>
        <div class="unaffected">Subsequent block.</div>
    """;
}
