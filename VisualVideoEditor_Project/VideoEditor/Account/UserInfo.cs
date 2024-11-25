using System;
using VisualVideoEditor_Project.VideoEditor.Account;

namespace VisualVideoEditor_Project
{
    public class UserInfo : IUserInfo
    {
        public string Username { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public DateTime LastAccessDate { get; set; }

        public void Save()
        {
            Properties.Settings.Default.Username = Username;
            Properties.Settings.Default.UserId = UserId;
            Properties.Settings.Default.Password = Password;
            Properties.Settings.Default.LastAccessDate = LastAccessDate;
            Properties.Settings.Default.Save();
        }

        public void Reset()
        {
            Properties.Settings.Default.Reset();
        }

        public bool IsUserExists(string username, string userId)
        {
            // 사용자 존재 여부 확인 로직
            // 실제로는 데이터베이스나 다른 저장소에서 확인해야 합니다.
            return false; // 예시로 항상 false 반환
        }
    }
}
