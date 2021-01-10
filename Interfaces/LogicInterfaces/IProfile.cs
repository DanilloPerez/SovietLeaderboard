namespace LogicLayer.Profile
{
    public interface IProfile
    {
        string Age { get; set; }
        string Avatar { get; set; }
        bool Darkmode { get; set; }
        string Password { get; set; }
        string UserID { get; set; }
        string UserName { get; set; }
    }
}