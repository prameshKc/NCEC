using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace DAL {
    public class DbConnection<T> : IConnection<T> where T : class {
        private readonly IConfiguration _congig;
        public DbConnection (IConfiguration _congig) {
            this._congig = _congig;

        }
        public IDbConnection GetDbConnection () {

            return new SqlConnection (_congig.GetConnectionString ("DbCon"));
        }

        public async Task AddAsync (string Query, CommandType type, DynamicParameters parm = null) {
            using (var conn = GetDbConnection ()) {
                conn.Open ();
                var taks = await conn.ExecuteAsync (Query, parm, commandType : type);
            }
        }

        public async Task DeleteAsync (string Query, CommandType type, DynamicParameters parm = null) {
            using (var conn = GetDbConnection ()) {
                conn.Open ();
                var taks = await conn.ExecuteAsync (Query, parm, commandType : type);
            }
        }

        public async Task<IEnumerable<T>> FilterAsync (Func<T, bool> predicate, string Query, CommandType type, DynamicParameters parm = null) {
            using (var conn = GetDbConnection ()) {
                conn.Open ();
                var data= await SqlMapper.QueryAsync<T> (conn, Query, parm, commandType : type);
                return data.Where(predicate);
            }
        }

        public async Task<T> GetFirstAsync (string Query, CommandType type, DynamicParameters parm = null) {
            using (var conn = GetDbConnection ()) {
                conn.Open ();
                return await SqlMapper.QueryFirstOrDefaultAsync<T> (conn, Query, parm, commandType : type);
            }
        }

        public async Task<IEnumerable<T>> GetListAsync (string Query, CommandType type, DynamicParameters parm = null) {
            using (var conn = GetDbConnection ()) {
                conn.Open ();
                return await SqlMapper.QueryAsync<T> (conn, Query, parm, commandType : type);
            }
        }

        public Task UpdateAsync (string Query, CommandType type, DynamicParameters parm = null) {
            throw new NotImplementedException ();
        }

        public void Dispose()
        {
           GetDbConnection().Close();
        }
    }
}