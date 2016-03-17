namespace Zen.Core.Interfaces
{
    public interface IZUser
    {
        string Username { get; set; }
        IZRole[] Roles { get; set; }
    }
}