namespace NetCoreTests.App.Services
{
    public sealed class GuidService
    {
        public Guid Id { get; init; } = Guid.NewGuid();
    }
}
