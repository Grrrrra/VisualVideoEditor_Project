using System;

namespace VisualVideoEditor_Project.VideoEditor.Account
{
     internal interface IUserInfo
    {
         string Username { get; set; }
        string UserId { get; set; }
        string Password { get; set; }
        DateTime LastAccessDate { get; set; }

        void Save();
        void Reset();
        bool IsUserExists(string username, string userId);

    }
}
