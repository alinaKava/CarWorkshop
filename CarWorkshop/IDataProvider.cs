using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarWorkshop.Models;

namespace CarWorkshop
{
    public interface IDataProvider<T>
    {
        IEnumerable<T> GetData();

        void RemoveItem(T item);

        void UpdateItem(T item);

        void AddItem(T item);
    }
}
