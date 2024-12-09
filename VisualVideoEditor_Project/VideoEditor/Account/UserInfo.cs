using System;
using System.Collections.Generic;
using System.IO;
using VisualVideoEditor_Project.VideoEditor.Account;

namespace VisualVideoEditor_Project
{
    public class UserInfo : IUserInfo, IFavoriteInfo
    {
        public string Username { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public DateTime LastAccessDate { get; set; }
        public List<string> Favorites { get; set; }

        private const string UserInfoFilePath = "userInfo.txt"; // 사용자 정보 파일 경로
        private const string FavoritesFilePath = "favorites.txt"; // 즐겨찾기 파일 경로

        public UserInfo()
        {
            Favorites = new List<string>(); // 즐겨찾기 리스트 초기화
        }
        public void LoadFavorites()
        {
            if (File.Exists(FavoritesFilePath))
            {
                Favorites.Clear(); // 기존 리스트 초기화
                var lines = File.ReadAllLines(FavoritesFilePath);
                foreach (var line in lines)
                {
                    Favorites.Add(line); // 파일에서 읽은 즐겨찾기를 추가
                }
            }
        }

        public void SaveFavorites()
        {
            using (StreamWriter writer = new StreamWriter(FavoritesFilePath, false))
            {
                foreach (var favorite in Favorites)
                {
                    writer.WriteLine(favorite);
                }
            }
        }
        public bool IsUserExists(string username, string userId)
        {
            if (File.Exists(UserInfoFilePath))
            {
                var lines = File.ReadAllLines(UserInfoFilePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        if (parts[0] == username && parts[1] == userId)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public void Save()
        {
            using (StreamWriter writer = new StreamWriter(UserInfoFilePath, true)) // append mode
            {
                writer.WriteLine($"{Username},{UserId},{Password},{LastAccessDate}");
            }
            SaveFavorites(); // 즐겨찾기 저장
        }

        public void Reset()
        {
            if (File.Exists(UserInfoFilePath))
            {
                File.Delete(UserInfoFilePath);
            }
            ResetFavorites(); // 즐겨찾기 초기화
        }

        

        private void ResetFavorites()
        {
            if (File.Exists(FavoritesFilePath))
            {
                File.Delete(FavoritesFilePath);
            }
            Favorites.Clear(); // 즐겨찾기 리스트 초기화
        }
    }
}
