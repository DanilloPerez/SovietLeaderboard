namespace Interfaces
{
    public interface ITeam
    {
        string OwnerID { get; set; }
        string TeamDescription { get; set; }
        string TeamID { get; set; }
        string TeamName { get; set; }
        bool AddPlayers(string UserID);
        bool Update();
    }
}