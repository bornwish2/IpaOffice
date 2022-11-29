using AutoMapper;

namespace Framework.Endpoints.Contracts
{
    public interface IHaveCustomMapping
    {
        void CreateMappings(Profile profile);
    }
}
