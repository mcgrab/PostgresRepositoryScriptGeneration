using System;
using System.Collections.Generic;
using System.Text;

namespace ScriptGeneration.Repository
{
    public interface ITestRepository<T> where T : class
    {
        void Add(T item);
        void Remove(long id);
        void Update(T item, dynamic where);
        IEnumerable<T> GetMany(dynamic where);
        T GetOne(dynamic where);
        IEnumerable<T> FindAll(int offset = 0, int count = 0, string order = "ASC");
    }
}
