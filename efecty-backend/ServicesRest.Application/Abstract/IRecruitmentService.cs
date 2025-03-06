using ServicesRest.Application.Dto;
using ServicesRest.Domain.Entity;

namespace ServicesRest.Application.Abstract
{
    public interface IRecruitmentService
    {
        Task<IEnumerable<PruebaDto>> GetPrueba();
        Task AddPrueba(PruebaDto prueba);
    }
}
