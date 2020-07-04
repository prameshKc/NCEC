namespace BLL.Implementation {
    using BLL.Abstract;
    using DAL;
    using DomainModel;
    using Microsoft.Extensions.Configuration;
    public class HeadlineRepo : DbConnection<Headline>, IHeadline {
        private readonly IConfiguration _config;
        public HeadlineRepo (IConfiguration _config) : base (_config) {
            this._config = _config;
        }
    }
}