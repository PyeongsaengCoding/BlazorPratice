using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPratice.Shared.Models
{
    public class RantadiMission
    {
        public string? MissionName { get; set; }
        public string? MissionBenefit { get; set; }
        public List<string> NormalUnit { get; set; } = new();
        public List<string> MagicUnit { get; set; } = new();
        public List<string> RarelUnit { get; set; } = new();
        public List<string> UniquelUnit { get; set; } = new();
        public List<string> EpiclUnit { get; set; } = new();
        public List<string> Citizen { get; set; } = new();
    }

    public class RantadiUnits
    {
        public const string Nomal_Hydralisk = "히드라";
        public const string Nomal_Vulture = "벌쳐";
        public const string Nomal_Dragoon = "드라군";
        public const string Nomal_Marine = "마린";
        public const string Nomal_Wraith = "레이스";
        public const string Nomal_Scout = "스카웃";
        public const string Nomal_Ultralist = "울트라";
        public const string Nomal_Mutalisk = "뮤탈";

        public const string Magic_ManGhost = "남고";
        public const string Magic_WomanGhost = "여고";
        public const string Magic_Scout = "스카웃";
        public const string Magic_Firebat = "파이어뱃";
        public const string Magic_SiegeTank = "시즈탱크";
        public const string Magic_DarkTemplar = "닥템";
        public const string Magic_DarkArchon = "다크아칸";
        public const string Magic_Defiler = "디파일러";

        public const string Rare_Devourer = "디바우러";
        public const string Rare_Ghost = "촉수";
        public const string Rare_Firebat = "파이어뱃";
        public const string Rare_Goliath = "골리앗";
        public const string Rare_Wraith = "레이스";
        public const string Rare_Arbiter = "아비터";
        public const string Rare_Dragoon = "드라군";
        public const string Rare_Defiler = "디파일러";
 
        public const string Unique_Guardian = "가디언";
        public const string Unique_Zergling = "저글링";
        public const string Unique_Hydralisk = "히드라";
        public const string Unique_DarkArchon = "다크아칸";
        public const string Unique_Marine = "마린";
        public const string Unique_Valkyrie = "발키리";
        public const string Unique_HighTemplar = "하템";
        public const string Unique_Reaver = "리버";

        public const string Epic_Lurker = "지옥불";
        public const string Epic_CloakingGhost = "유령";
        public const string Epic_Kerrigan = "여왕";
        public const string Epic_HighTemplar = "핵";
        public const string Epic_Vulture = "래피드";
        public const string Epic_Carrier = "거인";
        public const string Epic_Mutalisk = "수리검";
        public const string Epic_Yamato = "야마토";

        public const string Nomal_Citizen = "일반 시민";
        public const string Magic_Citizen = "매직 시민";
        public const string Rare_Citizen = "레어 시민";
        public const string Unique_Citizen = "유니크 시민";
        public const string Epic_Citizen = "에픽 시민";




    }

}
