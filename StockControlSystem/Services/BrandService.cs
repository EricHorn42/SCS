using Stock_control_system.Services;
using System.Collections;

namespace StockControlSystem.Services
{
    public class BrandService : IBaseService
    {
        ServiceDescriptor IList<ServiceDescriptor>.this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        int ICollection<ServiceDescriptor>.Count => throw new NotImplementedException();

        bool ICollection<ServiceDescriptor>.IsReadOnly => throw new NotImplementedException();

        void ICollection<ServiceDescriptor>.Add(ServiceDescriptor item)
        {
            throw new NotImplementedException();
        }

        void ICollection<ServiceDescriptor>.Clear()
        {
            throw new NotImplementedException();
        }

        bool ICollection<ServiceDescriptor>.Contains(ServiceDescriptor item)
        {
            throw new NotImplementedException();
        }

        void ICollection<ServiceDescriptor>.CopyTo(ServiceDescriptor[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        IEnumerator<ServiceDescriptor> IEnumerable<ServiceDescriptor>.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        int IList<ServiceDescriptor>.IndexOf(ServiceDescriptor item)
        {
            throw new NotImplementedException();
        }

        void IList<ServiceDescriptor>.Insert(int index, ServiceDescriptor item)
        {
            throw new NotImplementedException();
        }

        bool ICollection<ServiceDescriptor>.Remove(ServiceDescriptor item)
        {
            throw new NotImplementedException();
        }

        void IList<ServiceDescriptor>.RemoveAt(int index)
        {
            throw new NotImplementedException();
        }
    }
}
