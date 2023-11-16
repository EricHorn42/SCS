using StockControlSystem.Models;

namespace StockControlSystem.Infrastructure.Contexto.Repositories.Impl
{
    public class AddressRepositoryImpl : BaseRepository<Address, Context>
    {
        public AddressRepositoryImpl(Context context) : base(context)
        {
        }

        public override async Task<Address> Add(Address entity)
        {
            SupplierRepositoryImpl supplierRepositoryImpl = new SupplierRepositoryImpl(_context) ?? throw new ArgumentException("Toast time is too short.", nameof(entity));
            if (entity.SupplierID == null) { throw new ArgumentException("erro", nameof(entity)); }
            entity.Supplier = await supplierRepositoryImpl.Get((int)entity.SupplierID);
            return await base.Add(entity);
        }
    }
}
