namespace Lykke.OneSky.Json
{
    public interface IProjectNew : IProject
    {
        IProjectType ProjectType { get; }

        string Description { get; }
    }
}
