namespace BLL.Implementation
{   using BLL.Abstract;
    using DAL;
    using DomainModel;
    using Microsoft.Extensions.Configuration;
    public class SloganRepo: DbConnection<Slogan>, ISlogan
    {
        private readonly IConfiguration _config;
        public SloganRepo (IConfiguration _config) : base (_config) {
            this._config = _config;
        }
    }
}