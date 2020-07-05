namespace BLL.Implementation
{   using BLL.Abstract;
    using DAL;
    using DomainModel;
    using Microsoft.Extensions.Configuration;
    public class PartnersRepo: DbConnection<Partners>, IPartner
    {
        private readonly IConfiguration _config;
        public PartnersRepo (IConfiguration _config) : base (_config) {
            this._config = _config;
        }
        
    }
}