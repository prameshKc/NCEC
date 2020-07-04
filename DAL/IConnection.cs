using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Data;
using System.Threading.Tasks;
using Dapper;
namespace DAL {
    public interface IConnection<T> : IDisposable where T : class {
        IDbConnection GetDbConnection ();
        Task<T> GetFirstAsync (string sqlQuery, CommandType type, DynamicParameters parameters = null);
        Task<IEnumerable<T>> GetListAsync (string sqlQuery, CommandType type, DynamicParameters parameters = null);
        Task<IEnumerable<T>> FilterAsync (Func<T, bool> predicate, string sqlQuery, CommandType type, DynamicParameters parameters = null);
        Task AddAsync (string sqlQuery, CommandType type, DynamicParameters parameters = null);
        Task DeleteAsync (string sqlQuery, CommandType type, DynamicParameters parameters = null);
        Task UpdateAsync (string sqlQuery, CommandType type, DynamicParameters parameters = null);
    }
}