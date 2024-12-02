using System;

namespace VisualVideoEditor_Project.VideoEditor.Account
{
    public class AccountUser : UserInfo
    {
        public AccountUser()
        {
            LoadFavorites(); // 생성 시 즐겨찾기 로드
        }

        public void AddFavorite(string path)
        {
            if (!Favorites.Contains(path))
            {
                Favorites.Add(path);
                SaveFavorites(); // 즐겨찾기 저장
            }
        }

        public void RemoveFavorite(string path)
        {
            if (Favorites.Contains(path))
            {
                Favorites.Remove(path);
                SaveFavorites(); // 즐겨찾기 저장
            }
        }
    }
}
