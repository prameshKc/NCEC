namespace BLL.Implementation
{   using BLL.Abstract;
    using DAL;
    using DomainModel;
    using Microsoft.Extensions.Configuration;
    public class VenturesRepo: DbConnection<Ventures>, IVentures
    {
        private readonly IConfiguration _config;
        public VenturesRepo (IConfiguration _config) : base (_config) {
            this._config = _config;
        }
    }
}