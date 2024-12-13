using cs_prak_3.Models.Dto;

namespace MagicVilla_VillaAPI.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaDTOs = new List<VillaDTO> {
            new VillaDTO{Id = 1, Name = "00000" },
            new VillaDTO{Id = 2, Name = "22222" }
        };
    }
}