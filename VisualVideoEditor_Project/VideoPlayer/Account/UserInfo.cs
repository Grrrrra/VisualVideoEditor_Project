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
            // 즐겨찾기 파일에 저장하기 위해 StreamWriter를 사용
            using (StreamWriter writer = new StreamWriter(FavoritesFilePath, false))
            {
                // 즐겨찾기 리스트의 각 항목을 파일에 작성
                foreach (var favorite in Favorites)
                {
                    writer.WriteLine(favorite); // 즐겨찾기 항목을 한 줄씩 파일에 기록
                }
            }
        }

        public bool IsUserExists(string username, string userId)
        {
            // 사용자 정보 파일이 존재하는지 확인
            if (File.Exists(UserInfoFilePath))
            {
                // 파일의 모든 줄을 읽어옴
                var lines = File.ReadAllLines(UserInfoFilePath);
                // 각 줄에 대해 사용자 이름과 사용자 ID를 확인
                foreach (var line in lines)
                {
                    var parts = line.Split(','); // 줄을 ','로 분리하여 배열로 저장
                                                 // 배열의 길이가 3인지 확인 (이름, ID, 비밀번호가 포함되어야 함)
                    if (parts.Length == 3)
                    {
                        // 입력된 사용자 이름과 ID가 파일에 저장된 정보와 일치하는지 확인
                        if (parts[0] == username && parts[1] == userId)
                        {
                            return true; // 사용자 정보가 존재하면 true 반환
                        }
                    }
                }
            }
            return false; // 사용자 정보가 존재하지 않으면 false 반환
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
