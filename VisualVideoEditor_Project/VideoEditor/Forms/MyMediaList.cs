using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using Microsoft.VisualBasic; // InputBox 사용을 위한 네임스페이스 추가
using VisualVideoEditor_Project.VideoEditor.Account;

namespace VisualVideoEditor_Project.VideoEditor.Forms
{
    public partial class MyMediaList : MetroForm
    {
        private AccountUser currentUser; // 현재 사용자 계정

        public MyMediaList(AccountUser user)
        {
            InitializeComponent();
            currentUser = user; // 현재 사용자 계정 설정
            LoadFavorites(); // 즐겨찾기 로드
        }

        private void LoadFavorites()
        {
            lvPcList.Items.Clear(); // 기존 항목 삭제
            foreach (var favorite in currentUser.Favorites)
            {
                // 즐겨찾기 항목을 ','로 분리하여 파일 이름과 경로를 가져옴
                var parts = favorite.Split(new[] { ',' }, 2); // 최대 2개로 분리
                if (parts.Length == 2)
                {
                    AddItemToListView(parts[0], parts[1]); // 파일 이름과 경로를 리스트에 추가
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string videoPath = txtVideoPath.Text.Trim(); // 텍스트 박스에서 경로 가져오기

            if (!string.IsNullOrEmpty(videoPath)) // 경로가 비어있지 않으면
            {
                // 사용자에게 이름 입력 요청
                string fileName = Interaction.InputBox("이름을 입력하세요", "이름 입력", "");

                // 이름이 비어있지 않은 경우에만 추가
                if (!string.IsNullOrEmpty(fileName))
                {
                    // 즐겨찾기에 추가
                    string fullFavorite = $"{fileName},{videoPath}"; // 이름과 경로를 함께 저장
                    currentUser.AddFavorite(fullFavorite); // 즐겨찾기에 추가
                    LoadFavorites(); // 리스트 뷰 갱신
                    txtVideoPath.Clear(); // 텍스트 박스 비우기
                }
                else
                {
                    MessageBox.Show("이름을 입력하세요."); // 이름이 비어있을 경우 경고 메시지
                }
            }
            else
            {
                MessageBox.Show("비디오 경로를 입력하세요."); // 경로가 비어있을 경우 경고 메시지
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            // 선택된 항목 제거
            if (lvPcList.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lvPcList.SelectedItems)
                {
                    currentUser.RemoveFavorite(item.Text); // 즐겨찾기에서 제거
                    lvPcList.Items.Remove(item); // 리스트 뷰에서 선택된 항목 제거
                }
            }
            else
            {
                MessageBox.Show("제거할 항목을 선택하세요."); // 경고 메시지
            }
        }

        private void LvPcList_ItemActivate(object sender, EventArgs e)
        {
            // 리스트 뷰 항목 더블 클릭 시
            if (lvPcList.SelectedItems.Count > 0)
            {
                // 선택된 항목이 하나일 경우에만 처리
                if (lvPcList.SelectedItems.Count == 1)
                {
                    // 선택된 항목
                    var selectedItem = lvPcList.SelectedItems[0];

                    // 서브아이템이 2개 이상인지 확인
                    if (selectedItem.SubItems.Count > 1)
                    {
                        // 선택된 항목의 경로를 가져옴
                        string directoryPath = selectedItem.SubItems[1].Text; // Directory 열의 텍스트

                        // txtVideoPath 텍스트 박스에 경로를 설정
                        txtVideoPath.Text = directoryPath; // txtVideoPath에 경로 설정
                        txtVideoPath.SelectAll(); // 전체 선택
                    }
                    else
                    {
                        MessageBox.Show("선택된 항목에 경로 정보가 없습니다."); // 경고 메시지
                    }
                }
                else
                {
                    MessageBox.Show("하나의 항목만 선택해 주세요."); // 경고 메시지
                }
            }
        }

        private void AddItemToListView(string fileName, string directoryPath)
        {
            ListViewItem item = new ListViewItem(fileName); // Name 열에 파일 이름 추가
            item.SubItems.Add(directoryPath); // Directory 열에 경로 추가
            lvPcList.Items.Add(item); // 리스트뷰에 아이템 추가
        }

        private void txtVideoPath_Click(object sender, EventArgs e)
        {
            // 텍스트 박스의 텍스트가 초기값인 경우 공란으로 설정
            if (txtVideoPath.Text == "경로를 입력하세요.")
            {
                txtVideoPath.Clear(); // 텍스트 박스 초기화
            }

            // 텍스트 박스의 내용을 전체 선택
            txtVideoPath.SelectAll(); // 전체 선택
        }
    }
}
