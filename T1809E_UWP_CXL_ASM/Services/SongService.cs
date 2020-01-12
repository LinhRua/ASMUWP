using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T1809E_UWP_CXL_ASM.Models;

namespace T1809E_UWP_CXL_ASM.Services
{
    class SongService
    {
        public ObservableCollection<Song> LoadSong()
        {
            ObservableCollection<Song> list = new ObservableCollection<Song>();
            list.Add(new Song()
            {
                SongName = "Mượn rượu tỏ tình",
                Link = " https://c1-ex-swe.nixcdn.com/NhacCuaTui976/MuonRuouToTinh-EmilyBigDaddy-5871420.mp3",
                Views = 123,
                Description = "Bigdaddy, Emily",
                Thumbnail =
                    "https://znews-photo.zadn.vn/w1024/Uploaded/qfssu/2019_02_08/batch_dsc_2961_1.jpg"
            });
            list.Add(new Song()
            {
                SongName = "Lang Thang",
                Link = "https://c1-ex-swe.nixcdn.com/NhacCuaTui993/LangThang-Rhymastic-6184222.mp3",
                Views = 456,
                Description = "Rhymastic",
                Thumbnail = "https://photo-zmp3.zadn.vn/cover_artist/e/0/e09915ec25d2d8e52aaf0d9381121da8_1503980596.jpg"
            });
            list.Add(new Song()
            {
                SongName = "7 Tỷ Người",
                Link = "https://vnno-vn-5-tf-mp3-s1-zmp3.zadn.vn/db0ccc32ee75072b5e64/633399884026569431?authen=exp=1578824447~acl=/db0ccc32ee75072b5e64/*~hmac=5d064c5020e1f869e81febe8f4393fb5&filename=7-Ty-Nguoi-Piano-Version-Acy-Xuan-Tai-Lynk-Lee.mp3",
                Views = 789,
                Description = "Piano Vision ",
                Thumbnail = "https://lh4.googleusercontent.com/3MbANHBCgyD88W9FtHF32gXsutBQZw4mIpzRFhw54uDJfpniNMmoIe9MIpGXpP-HAkZgiAS2hF5P2HDFMBpZIIioqXZVBDOmfU_t6nzFLGnAID1tYIS_uVejUtYwqA"
            });

            return list;
        }
    }
}
