using ServicesRest.Domain.Entity;

namespace ServicesRest.Domain.Abstract
{
    public interface IRecruitmentRepository
    {
        Task<IEnumerable<Prueba>> Get();
        Task Add(Prueba prueba);

        //Task<Prueba> Update(Prueba prueba);
        //Task<Prueba> Delete(Prueba prueba);
    }
}
