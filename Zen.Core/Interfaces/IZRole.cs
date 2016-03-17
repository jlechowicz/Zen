namespace Zen.Core.Interfaces
{
    public interface IZRole
    {
        string Name { get; set; }
        IZUser[] UsersInRole { get; set; }
    }
}